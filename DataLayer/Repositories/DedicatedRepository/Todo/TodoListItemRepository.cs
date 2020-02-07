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
            var result =  _context.TodoList.Include(i => i.TodoItems).Where(w => w.ApplicationUserId == userId);

            return result.ToList();
        
        
        }

        public List<TodoItem> GetAllTodoItemsInLastDays(string userId,int dayCount)
        {

            

            var minDate = DateTime.Now.AddDays(dayCount * -1);
            var result = _context.TodoItem.Where(w => w.TodoList.ApplicationUserId  == userId && w.DoneDate.Value >= minDate && w.DoneDate <= DateTime.Now);

            return result.ToList();


        }
    }
}
