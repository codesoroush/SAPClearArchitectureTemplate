using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IUserService
    {
        Task<List<ApplicationUser>> GetOtherUsers(string userId);
        Task<ApplicationUser> FindUserByUserName(string userName);

    }
}
