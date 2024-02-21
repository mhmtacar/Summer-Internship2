using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.web.Models
{
    public class HotelInfos
    {
        public string HotelName { get; set; }
        public string HotelPic { get; set; }
        public double HotelPrice { get; set; }
        public string HotelAdress { get; set; }
        public string HotelOfferId { get; set; }
        public string HotelId { get; set; }
        public HotelInfos(string hotelName, string hotelPic, double hotelPrice, string hotelAdress, string hotelOfferId, string hotelId)
        {
            HotelName = hotelName;
            HotelPic = hotelPic;
            HotelPrice = hotelPrice;
            HotelAdress = hotelAdress;
            HotelOfferId = hotelOfferId;
            HotelId = hotelId;
        }
    }
}
