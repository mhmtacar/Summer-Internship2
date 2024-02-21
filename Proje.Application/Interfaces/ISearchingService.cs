using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface ISearchingService
    {
        Task<List<CityInfos>> SearchCities(string query, string token);
    }
}
