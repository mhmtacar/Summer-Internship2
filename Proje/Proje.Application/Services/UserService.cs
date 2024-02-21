using Microsoft.Extensions.Logging;
using Proje.Application.Interfaces;
using Proje.Data;
using Proje.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proje.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UserService> _logger;
        public UserService(IUnitOfWork unitOfWork, ILogger<UserService> logger)
        {

           
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        //Basic Crud opsions
        #region Crud With Unit Of Work
        //User Add
        public void Add(User user)
        {
            _unitOfWork.User.Add(user);
            _unitOfWork.Complete();
            _logger.LogInformation("Yeni kullanici eklendi.", user);
        }

        //User ChangeStatus
        public void ChangeStatus(int? id)
        {
            var user = _unitOfWork.User.Get(id);
            if (user.AccountStatus == Status.active)
            {
                user.AccountStatus = Status.deActive;
                _logger.LogInformation($"{user.Username} adli kullanicinin statusu pasif durumuna getirildi.", user);
            }
            else if (user.AccountStatus == Status.deActive)
            {
                user.AccountStatus = Status.active;
                _logger.LogInformation($"{user.Username} adli kullanicinin statusu aktif durumuna getirildi.", user);
            }
            _unitOfWork.Complete();
        }
        //User Edit
        public void Edit(User user)
        {
            _unitOfWork.User.Update(user);
            _unitOfWork.Complete();
            _logger.LogInformation($"{user.Username} adli kullanicinin bilgileri degistirildi.", user);
        }

        //User Get
        public User Get(int? id)
        {
            return _unitOfWork.User.Get(id);
        }

        //User Get All
        public IEnumerable<User> GetAll()
        {
            return _unitOfWork.User.GetAll();
        }

        //User Delete
        public void Remove(User user)
        {
            _unitOfWork.User.Remove(user);
            _unitOfWork.Complete();
            _logger.LogInformation($"{user.Username} adli kullanici silindi.", user);
        }
        #endregion//Basic Crud opsions
        //Send Post
    } 

}
