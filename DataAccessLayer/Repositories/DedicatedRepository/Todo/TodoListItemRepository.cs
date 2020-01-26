using BussinessLayer.Entities;
using DataAccessLayer.Context;
using DataAccessLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories.DedicatedRepository.Todo
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
