using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.DedicatedRepository.AbsenceRep
{
    public class AbsenceRepository : Repository<Absence>, IAbsenceRepository
    {
        private ApplicationDbContext _context;

        public AbsenceRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}