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

namespace Proje.Application.Services
{
    public class PriceSearchingService : IPriceSearchingService
    {
        
        public async Task<List<HotelInfos>> PriceSearch(string CityId,string token)
        {
            List<HotelInfos> list = new List<HotelInfos>();

            //Request Json Body
            PriceSearchRequest.ArrivalLocation addCityId = new PriceSearchRequest.ArrivalLocation() { id = CityId };
            PriceSearchRequest.Root priceSearchingRequest = new PriceSearchRequest.Root();
            priceSearchingRequest.arrivalLocations.Add(addCityId);

            var json = JsonConvert.SerializeObject(priceSearchingRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/productservice/pricesearch";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);

            //If response is success filter for Hotel Details an Price
            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                var model = System.Text.Json.JsonSerializer.Deserialize<PriceSearchResponse.Root>(id);
                foreach (var hotel in model.body.hotels)
                {
                    foreach (var offer in hotel.offers)
                    {
                        list.Add(new HotelInfos(hotel.name, hotel.thumbnailFull, offer.price.amount, hotel.address, offer.offerId, hotel.id));
                    }

                }

            }
            return list;

        }
        
    }
}
