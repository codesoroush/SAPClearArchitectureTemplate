using BussinessLayer.Entities;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.DedicatedRepository.Todo
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
