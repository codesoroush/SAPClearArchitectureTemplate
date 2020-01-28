using BussinessLayer.Entities;
using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class AbsenceService : IAbsenceService
    {
        private UnitOfWork _uow;

        public AbsenceService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public async Task<Absence> EnterWork(Absence absence)
        {
            if ((await GetTodayAbsence(absence.ApplicationUserId)) == null)
            {
             
                var result =  await _uow.AbsenceGate.AddAsync(absence);
                await _uow.CommitAsync();
                return result;
            }
            return null;
        }

        public async Task<Absence> GetTodayAbsence(string userId)
        {
            return await _uow.AbsenceGate.GetTodayAbsence(userId);
        }

        public async Task Update(Absence absence)
        {
            _uow.AbsenceGate.Update(absence);
            await _uow.CommitAsync();
        }
    }
}
