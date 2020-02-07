using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.DedicatedRepository.AbsenceRep
{
    public class AbsenceRepository : Repository<Absence>, IAbsenceRepository
    {
        private ApplicationDbContext _context;

        public AbsenceRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }


        public async Task<Absence> GetTodayAbsence(string userId)
        {
            var result = await _context.Absence.Include(i => i.EnterInfo).FirstOrDefaultAsync(f => f.Entry.Date == DateTime.Now.Date && f.ApplicationUserId == userId);
            return result;
        }
    }
}