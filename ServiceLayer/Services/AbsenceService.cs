using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public class AbsenceService : IAbsenceService
    {
        private UnitOfWork _uow;

        public AbsenceService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

    }
}
