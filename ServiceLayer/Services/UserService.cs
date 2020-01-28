using BussinessLayer.Entities;
using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer.Services
{
    public class UserService: IUserService
    {
        private UnitOfWork _uow;

        public UserService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }
        public async Task<List<ApplicationUser>> GetOtherUsers(string userId)
        {
            List<ApplicationUser> users = (await _uow.User.GetAll()).Where(w => w.Id != userId).ToList();

            return users;
        }

    }
}
