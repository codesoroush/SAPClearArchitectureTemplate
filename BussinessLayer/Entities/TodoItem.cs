﻿using BussinessLayer.Enums;
using System;
using System.Collections.Generic;
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

        public PriorityLevel Priority { get; set; }


        #region Entity Relations
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }

        #endregion

    }
}