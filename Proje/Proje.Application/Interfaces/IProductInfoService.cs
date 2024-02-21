using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface IProductInfoService
    {
        Task<ProductInfos> GetProductInfo(string HotelId, string OfferId, string token);
    }
}
