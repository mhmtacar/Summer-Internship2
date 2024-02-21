using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Proje.Application.Interfaces;
using Proje.Data;
using Proje.web.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace Proje.web.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static string token;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBeginTransactionService _beginTransactionservice;
        private readonly ISearchingService _searching;
        private readonly IPriceSearchingService _priceSearching;
        private readonly IProductInfoService _productInfoService;
        private readonly ISetReservationService _setReservationService;
        private readonly ICommitTransactionService _commitTransactionService;
        private readonly IReservationDetailService _reservationDetailService;

        public HomeController(ILogger<HomeController> logger, IBeginTransactionService beginTransactionservice, ISearchingService searching, IProductInfoService productInfoService, ISetReservationService setReservationService, ICommitTransactionService commitTransactionService, IReservationDetailService reservationDetailService, IPriceSearchingService priceSearching, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _beginTransactionservice = beginTransactionservice;
            _searching = searching;
            _productInfoService = productInfoService;
            _setReservationService = setReservationService;
            _commitTransactionService = commitTransactionService;
            _reservationDetailService = reservationDetailService;
            _priceSearching = priceSearching;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            var reservations = _unitOfWork.ReservationSave.GetAll();
            //var users = _db.Users.Select(x=>x.AccountStatus!=Status.deleted).ToList();
            //var users = _db.Users.ToList();
            return View(reservations);
        }

        [HttpPost]
        public async Task<IActionResult> LoginUser(string username, string password)
        {
            #region YONTEM1

            /* DİĞER YÖNTEM

               using (var httpClient = new HttpClient())
               {
                   var myObject = new UserInfo

                   {
                       Agency = "PXM25397",
                       User = "USR1",
                       Password = "test!23"
                   };
                   StringContent stringContent = new StringContent(JsonConvert.SerializeObject(myObject), Encoding.UTF8, "application/json");
                   using (var response = await httpClient.PostAsync("http://service.stage.paximum.com/v2/api/authenticationservice/login", stringContent))
                   {
                       string token = await response.Content.ReadAsStringAsync();
                       if (token == "Invalid credentials")
                       {
                           ViewBag.Message = "Incorrent UserId or Password!";
                           return Redirect("~/Home/Index");
                       }
                       HttpContext.Session.SetString("JWToken", token);
                   }
                   return Redirect("~/Dashboard/Index");
               }
               }
           */
            #endregion
            #region YONTEM2

            //var myObject2 = new GetArrival();
            //var json2 = JsonConvert.SerializeObject(myObject2);
            //var data2 = new StringContent(json2, Encoding.UTF8, "application/json");

            //var url2 = "http://service.stage.paximum.com/v2/api/productservice/getarrivalautocomplete";
            //using var client2 = new HttpClient();

            //var response2 = await client.PostAsync(url2, data2);

            //var result2 = await response2.Content.ReadAsStringAsync();

            //Console.WriteLine(result2);
            #endregion

            string url = "http://service.stage.paximum.com/v2/api/authenticationservice/login";
            var myObject = new UserInfo();
            myObject.User = username;
            myObject.Password = password;
            var json = JsonConvert.SerializeObject(myObject);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            var model = System.Text.Json.JsonSerializer.Deserialize<LoginResponse.Root>(result);

            if (model.body == null)
            {
                _logger.LogInformation("Wrong user");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                token = model.body.token;
                return RedirectToAction("SearchBar", "Home");
            }
        }
        [HttpGet]
        public async Task<IActionResult> SearchBar()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> GetArrivalAutoComplete(string query)
        {
            var result = await _searching.SearchCities(query,token);
            // Show Cities
            return View(result);
        }

        public async Task<IActionResult> PriceSearch(string CityId) // Price Search with City Id
        {
            var hotels = await _priceSearching.PriceSearch(CityId,token);
            return View(hotels);
        }

        public async Task<IActionResult> GetProductInfo(string HotelId, string OfferId) // Price Search with City Id
        {
            var hoteldetail = await _productInfoService.GetProductInfo(HotelId, OfferId,token);
            return View(hoteldetail);

        }

        public async Task<IActionResult> Booking(string FirstName, string LastName, string Email, string OfferId) //Booking procces
        {

              var transactionId = await _beginTransactionservice.BeginTransaction(OfferId,token);
               var setReservation = await _setReservationService.SetReservation(FirstName, LastName, Email, transactionId,token);
                return View(setReservation);
        }


        public async Task<IActionResult> CompleteReservation(string TransactionId)
        {
            var reservationNumber = await _commitTransactionService.CompleteReservation(TransactionId,token);
            var details = await _reservationDetailService.SaveReservation(reservationNumber,token);
            return View(details);
         }

            
            /*
            // Commit Transaction , It saves the reservation information.
            var reservationNumber = await _commitTransactionService.CompleteReservation(TransactionId);
            // Reservation Detail , It saves the reservation information to the database.
            var details = await _reservationDetailService.SaveReservation(reservationNumber);
            return View(details);
            */
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}