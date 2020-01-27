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
    public class TodoListItemRepository : Repository<TodoList>, ITodoListItemRepository
    {
        private ApplicationDbContext _context;

        public TodoListItemRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public List<TodoList> GetAllWithTodoesChilds(string userId)
        {
            var result =  _context.Todoes.Include(i => i.TodoItems).Where(w => w.ApplicationUserId == userId);

            return result.ToList();
        
        
        }
    }
}
