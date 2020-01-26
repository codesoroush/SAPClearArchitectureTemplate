using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
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
    }
}
