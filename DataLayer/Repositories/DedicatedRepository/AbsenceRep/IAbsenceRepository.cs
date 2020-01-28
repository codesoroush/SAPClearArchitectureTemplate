using BussinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.DedicatedRepository.AbsenceRep
{
     public interface IAbsenceRepository
    {
        Task<Absence> GetTodayAbsence(string userId);
    }
}
