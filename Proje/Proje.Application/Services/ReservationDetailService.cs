using Newtonsoft.Json;
using Proje.Application.Interfaces;
using Proje.Data;
using Proje.web.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Services
{
    public class ReservationDetailService : IReservationDetailService
    {
        private readonly IUnitOfWork _unitOfWork;
        

        public ReservationDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            
        }

        
        public async Task<Reservations> SaveReservation(string reservationNumber,string token)
        {
            //Request Json Body
            Reservations reservations = null;
            ReservationDetailRequest reservationDetailRequest = new ReservationDetailRequest() { reservationNumber = reservationNumber };

            var json = JsonConvert.SerializeObject(reservationDetailRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/bookingservice/getreservationdetail";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);

            //If response is success set to Reservation details
            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                ReservationDetailResponse.Rootobject deserializedJson = JsonConvert.DeserializeObject<ReservationDetailResponse.Rootobject>(id);

                var resarvationData = deserializedJson.body.reservationData;
                reservations = new Reservations
                {
                    TotalPrice = resarvationData.reservationInfo.totalPrice.amount,
                    HotelName = resarvationData.services[0].name,
                    Night = resarvationData.services[0].serviceDetails.night,
                    Room = resarvationData.services[0].serviceDetails.room,
                    BeginDate = resarvationData.services[0].beginDate,
                    EndDate = resarvationData.services[0].endDate,
                    Adult = resarvationData.services[0].adult,
                    reservationNumber = resarvationData.services[0].code,
                    TravallerName = resarvationData.travellers[0].name,
                    TravallerSurname = resarvationData.travellers[0].surname,
                    TravallerEmail = resarvationData.travellers[0].address.email
                };
                /*
                _unitOfWork.ReservationSave.Add(reservations);
                _unitOfWork.Complete();
                */
                _unitOfWork.ReservationSave.Add(reservations);
                _unitOfWork.Complete();
            }
            return reservations;

        }
        
    }
}
