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
    public class CommitTransactionService : ICommitTransactionService
    {

        public async Task<string> CompleteReservation(string TransactionId, string token)
        {

            CommitTransactionRequest commitTransactionRequest = new CommitTransactionRequest() { TransactionId = TransactionId };
            var json = JsonConvert.SerializeObject(commitTransactionRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/bookingservice/committransaction";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);


            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                JObject json2 = JObject.Parse(id);
                var reservationNumber = json2.SelectToken("body.reservationNumber").Value<string>();
                return reservationNumber;

            }
            return null;
        }
    }
}
