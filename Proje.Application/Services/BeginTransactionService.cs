using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public class BeginTransactionService : IBeginTransactionService
    {
        

        public async Task<string> BeginTransaction(string OfferId,string token)
        {
            //Request Json Body
            BeginTransactionRequest productInfoRequest = new BeginTransactionRequest();
            productInfoRequest.offerIds.Add(OfferId);

            var json = JsonConvert.SerializeObject(productInfoRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/bookingservice/begintransaction";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);

            //If response is success , Select transaction id in json object.
            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                JObject json2 = JObject.Parse(id);
                var transactionId = json2.SelectToken("body.transactionId").Value<string>();
                return transactionId;

            }
            return null;
        }
    }
}
