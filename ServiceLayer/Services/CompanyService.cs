using BussinessLayer.Entities;
using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CompanyService:ICompanyService
    {
        private UnitOfWork _uow;

        public CompanyService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public async Task<Company> CreateCompany(Company company)
        {
            var result = await _uow.CompanyGate.AddAsync(company);
            await _uow.CommitAsync();
            return result;
        }
    }
}
