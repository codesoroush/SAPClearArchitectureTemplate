using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.DedicatedRepository.UserRep
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUserByUserName(string userName);
    }
}
