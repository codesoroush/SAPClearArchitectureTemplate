using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class ApplicationUser:IdentityUser
    {

        public string FullName { get; set; }
        public DateTime  RegisterDate { get; set; } = DateTime.Now;
        public DateTime LastOnlineDate { get; set; } = DateTime.Now;
        public DateTime? LastPasswordResetDate { get; set; }
        public string ConnectionId { get; set; }
        public string Avatar { get; set; }
        public virtual List<TodoList> Todoes { get; set; }
        public virtual List<Absence> Absences { get; set; }

    }
}
