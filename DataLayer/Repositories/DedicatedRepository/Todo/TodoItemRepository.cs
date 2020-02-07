using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repositories.DedicatedRepository.Todo
{
    public class TodoItemRepository : Repository<TodoItem>, ITodoItemRepository
    {
        private ApplicationDbContext _context;

        public TodoItemRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<TodoItem> GetUndoneTodoItemInTomorrow()
        {
            var result = _context.TodoItem.Where(w => w.DueDate.Value.Date == DateTime.Now.AddDays(1).Date && !w.Done);
            return result.ToList();
        }
    }
}
