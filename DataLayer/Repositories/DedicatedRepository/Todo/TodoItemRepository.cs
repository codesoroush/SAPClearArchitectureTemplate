using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
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
    }
}
