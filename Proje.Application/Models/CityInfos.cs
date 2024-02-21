using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.web.Models
{
    public class CityInfos
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public CityInfos(string id, string name, string country)
        {
            Id = id;
            Name = name;
            Country = country;
        }
    }
}
