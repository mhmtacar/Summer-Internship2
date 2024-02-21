using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface IPriceSearchingService
    {
        public Task<List<HotelInfos>> PriceSearch(string CityName,string token);
    }
}
