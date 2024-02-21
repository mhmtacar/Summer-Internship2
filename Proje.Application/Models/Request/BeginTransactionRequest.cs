using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.web.Models
{
    public class BeginTransactionRequest
    {
        public List<string> offerIds { get; set; } = new List<string>();
        public string Currency { get; set; } = "EUR";
        public string Culture { get; set; } = "en-US";
    }
}
