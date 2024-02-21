using Microsoft.AspNetCore.Mvc;
using Proje.Data;
using Proje.Domain;


namespace Proje.web.Controllers
{
    public class UserController : Controller
    {
        // Dependence İnjection
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            var users = _unitOfWork.User.GetAll();
            //var users = _db.Users.Select(x=>x.AccountStatus!=Status.deleted).ToList();
            //var users = _db.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.User.Add(user);
                _unitOfWork.Complete();
                return RedirectToAction("Index", "User");
            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == null)
                return RedirectToAction("Index", "User");

            User user = _unitOfWork.User.Find(id);// secili user aldin
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                User editedUser = _unitOfWork.User.Find(user.Id);
                editedUser.Username = user.Username;
                editedUser.Email = user.Email;
                editedUser.Password = user.Password;
                _unitOfWork.Complete();
                return RedirectToAction("Index", "User");
            }
            return BadRequest("eksik bilgi girdiniz");
        }



        [HttpGet]
        public IActionResult Delete(int id)
        {
            User user = _unitOfWork.User.Find(id);// secili user aldin
            if (user==null)
                return RedirectToAction("Index", "User");

       
            return View(user);
        }


        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        //    public IActionResult DeleteConfirmed(User user)
        {
            User editedUser = _unitOfWork.User.Find((int)id);
           // User editedUser = _db.Users.Find(user.Id);
            if (editedUser==null)
                return RedirectToAction("Index", "User");

            editedUser.AccountStatus = Status.deleted;
            _unitOfWork.Complete();
            return RedirectToAction("Index", "User");
        }




        [HttpGet]
        public IActionResult ChangeStatus(int? id)
        {
            User user = _unitOfWork.User.Find((int)id);// secili user aldin
            if (user == null)
                return RedirectToAction("Index", "User");

            if (user.AccountStatus != Status.deleted && user.AccountStatus == Status.active)
                user.AccountStatus = Status.deActive;
            else if (user.AccountStatus != Status.deleted && user.AccountStatus == Status.deActive)
                user.AccountStatus = Status.active;
            _unitOfWork.Complete();
            return RedirectToAction("Index", "User");
        }

       
    }
}
