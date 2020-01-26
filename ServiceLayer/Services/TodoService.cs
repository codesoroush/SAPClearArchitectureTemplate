using DataLayer.Uow;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Services
{
    public class TodoService:ITodoService
    {
        private UnitOfWork _uow;

        public TodoService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }
    }
}
