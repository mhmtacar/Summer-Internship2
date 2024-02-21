using Newtonsoft.Json;
using Proje.Application.Interfaces;
using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SanTsgProje.Application.Services
{
    public class ProductInfoService : IProductInfoService
    {
    
        public async Task<ProductInfos> GetProductInfo(string HotelId, string OfferId,string token)
        {
            ProductInfos productInfo = null;

            //Request Json Body
            ProductInfoRequest productInfoRequest = new ProductInfoRequest() { Product = HotelId };

            var json = JsonConvert.SerializeObject(productInfoRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/productservice/getproductInfo";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);

            //If response is success filter for Hotel Details an Price
            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                ProductInfoResponse.Root deserializedJson = JsonConvert.DeserializeObject<ProductInfoResponse.Root>(id);

                productInfo = new ProductInfos
                {
                    HotelName = deserializedJson.body.hotel.name,
                    HotelPic = deserializedJson.body.hotel.thumbnailFull,
                    HotelPhone = deserializedJson.body.hotel.phoneNumber,
                    HotelWeb = deserializedJson.body.hotel.homePage,
                    HotelRate = deserializedJson.body.hotel.stars,
                    Description = deserializedJson.body.hotel.description.text,
                    OfferId = OfferId
                };



                foreach (var item in deserializedJson.body.hotel.seasons[0].facilityCategories[0].facilities)
                {
                    productInfo.HotelFacility.Add(item.name);
                }


            }
            return productInfo;
        }
    }
}
