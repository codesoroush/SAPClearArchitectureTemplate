using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface ICompanyService
    {
        Task<Company> CreateCompany(Company company);
    }
}
