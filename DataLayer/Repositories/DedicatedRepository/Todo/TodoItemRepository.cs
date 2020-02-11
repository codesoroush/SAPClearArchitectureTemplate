using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
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

        public List<TodoItem> GetUndoneTodoItemInTomorrow(string userId)
        {
            var result = _context.TodoItem.Include( i => i.TodoItemCategory).Where(w => w.TodoList.ApplicationUserId == userId && !w.Done);
            return result.ToList();
        }
    }
}
