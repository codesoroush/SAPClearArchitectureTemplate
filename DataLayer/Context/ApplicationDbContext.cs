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

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<TodoList> Todoes { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<DailyLeaves> DailyLeaves { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
        {
        }
    }
}
