using Newtonsoft.Json;
using Proje.Application.Interfaces;
using Proje.web.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SanTsgProje.Application.Services
{
    public class SearchingService : ISearchingService
    {
        

        public async Task<List<CityInfos>> SearchCities(string query,string token) //Searching Cities 
        {
            List<CityInfos> list2 = new List<CityInfos>();
            var myObject = new GetArrivalRequest();
            myObject.Query = query;
            var json = JsonConvert.SerializeObject(myObject);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://service.stage.paximum.com/v2/api/productservice/getarrivalautocomplete";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(url, data);
            var result2 = await response.Content.ReadAsStringAsync();
            var model = System.Text.Json.JsonSerializer.Deserialize<GetArrivalResponse.Root>(result2);

            foreach (var item in model.body.items)
            {
                if (item.country.id == "TR" && item.type == 1)
                {
                    list2.Add(new CityInfos(name: item.city.name, id: item.city.id, country: item.country.id));
                }
            }
            return list2;

        }
    }

}
