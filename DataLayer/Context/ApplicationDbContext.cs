using BussinessLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<TodoItem> TodoItem { get; set; }
        public DbSet<TodoList> TodoList { get; set; }
        public DbSet<Absence> Absence { get; set; }
        public DbSet<DailyLeaves> DailyLeaves { get; set; }
        public DbSet<TodoItemCategory> TodoItemCategory { get; set; }
        public DbSet<Company> Company { get; set; }

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
    }
}
