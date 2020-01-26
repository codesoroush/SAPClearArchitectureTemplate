using BussinessLayer.Entities;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories.DedicatedRepository.Todo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public TodoListItemRepository TodoList { get; }
        public TodoItemRepository TodoItem { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            TodoItem = new TodoItemRepository(context);
            TodoList = new TodoListItemRepository(context);


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
