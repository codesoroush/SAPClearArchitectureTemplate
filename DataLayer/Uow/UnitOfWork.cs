using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.DedicatedRepository.AbsenceRep;
using DataLayer.Repositories.DedicatedRepository.CompanyRep;
using DataLayer.Repositories.DedicatedRepository.Todo;
using DataLayer.Repositories.DedicatedRepository.UserRep;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public TodoListItemRepository TodoList { get; }
        public AbsenceRepository AbsenceGate { get; }
        public TodoCategoryRepository TodoItemCategoryGate { get; }
        public UserRepository User { get; }
        public CompanyRepository CompanyGate { get; }
        public TodoItemRepository TodoItem { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            TodoItem = new TodoItemRepository(context);
            TodoList = new TodoListItemRepository(context);
            AbsenceGate = new AbsenceRepository(context);
            TodoItemCategoryGate = new TodoCategoryRepository(context);
            User = new UserRepository(context);
            CompanyGate = new CompanyRepository(context);


        }


        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
