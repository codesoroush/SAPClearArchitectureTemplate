using BussinessLayer.ExtentionMethods;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class TodoList:BaseEntity
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Color { get; set; } = SAPGenerator.GenerateHexColorCode;

        public virtual List<TodoItem> TodoItems { get; set; } = new List<TodoItem>();
        public void GenerateColor()
        {
            this.Color = SAPGenerator.GenerateHexColorCode; 
        }

        #region Entity Relations
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        #endregion
    }
}
