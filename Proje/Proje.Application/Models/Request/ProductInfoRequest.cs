using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.web.Models
{
    public class ProductInfoRequest
    {
        public int ProductType { get; set; } = 2;
        public int OwnerProduct { get; set; } = 2;
        public string Product { get; set; }
        public string Culture { get; set; } = "en-US";
    }
}
