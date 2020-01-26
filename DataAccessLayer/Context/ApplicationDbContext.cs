using BussinessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> Todoes { get; set; }



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
    }
}
