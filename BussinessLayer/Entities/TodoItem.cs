using BussinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BussinessLayer.Entities
{
    public class TodoItem:BaseEntity
    {


        public long Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public bool Done { get; set; }

        public DateTime? Reminder { get; set; }
        public DateTime? DoneDate { get; set; }
        public DateTime? DueDate { get; set; } = DateTime.Now.Hour > 10 ? DateTime.Now.AddDays(1) : DateTime.Now;
        public TodoProgress TodoProgress { get; set; } = TodoProgress.Created;
        public int Point { get; set; } = 0;
        public PriorityLevel Priority { get; set; }
        public TodoItemCategory TodoItemCategory { get; set; }

        [NotMapped]
        public virtual bool Focoused { get; set; } = false;


        #region Entity Relations
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }

        #endregion

    }
}
