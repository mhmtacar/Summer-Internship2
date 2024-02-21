using Newtonsoft.Json;
using Proje.Application.Interfaces;
using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SanTsgProje.Application.Services
{
    public class SetReservationService : ISetReservationService
    {
     

     
        public async Task<Reservation> SetReservation(string FistName, string LastName, string Email, string transactionId,string token)
        {
            Reservation reservation = null;

            //Request Json Body
            #region SetReservation Request
            SetReservationRequest.Rootobject reservationRequest = new SetReservationRequest.Rootobject()
            {
                // Set Reservation Informations
                transactionId = transactionId,
                travellers = new SetReservationRequest.Traveller[]
                {
                    new SetReservationRequest.Traveller(FistName,LastName,Email)
                }
            };

            #endregion
            var json = JsonConvert.SerializeObject(reservationRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            //Api Url for post
            var addurl = "http://service.stage.paximum.com/v2/api/bookingservice/setreservationinfo";

            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await client.PostAsync(addurl, data);

            //If response is success filter for Hotel Details an Price
            if (response.IsSuccessStatusCode)
            {
                var id = await response.Content.ReadAsStringAsync();
                SetReservationResponse.Rootobject deserializedJson = JsonConvert.DeserializeObject<SetReservationResponse.Rootobject>(id);
                reservation = new Reservation
                {
                    HotelName = deserializedJson.body.reservationData.services[0].serviceDetails.hotelDetail.name,
                    TotalPrice = deserializedJson.body.reservationData.services[0].price.amount,
                    BeginDate = deserializedJson.body.reservationData.services[0].beginDate,
                    EndDate = deserializedJson.body.reservationData.services[0].endDate,
                    Adult = deserializedJson.body.reservationData.services[0].adult,
                    Room = deserializedJson.body.reservationData.services[0].serviceDetails.room,
                    Night = deserializedJson.body.reservationData.services[0].serviceDetails.night,
                    TravallerName = FistName,
                    TravallerSurname = LastName,
                    TravallerEmail = Email,
                    TransactionId = transactionId
                };

            }
            return reservation;

        }
    }
}
