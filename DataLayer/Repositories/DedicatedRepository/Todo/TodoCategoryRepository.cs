using BussinessLayer.Entities;
using DataLayer.Context;
using DataLayer.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repositories.DedicatedRepository.Todo
{
    public class TodoCategoryRepository : Repository<TodoItemCategory>, ITodoCategoryRepository
    {
        private ApplicationDbContext _context;

        public TodoCategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
