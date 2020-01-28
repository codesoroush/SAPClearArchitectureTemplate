using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public interface IAbsenceService
    {
        Task<Absence> GetTodayAbsence(string userId);
        Task<Absence> EnterWork(Absence absence);
        Task Update(Absence absence);
    }
}
