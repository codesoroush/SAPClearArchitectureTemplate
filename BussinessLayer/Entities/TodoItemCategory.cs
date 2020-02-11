using BussinessLayer.ExtentionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BussinessLayer.Entities
{
    public class TodoItemCategory
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(12)]
        public string ColorCode { get; set; } = SAPGenerator.GenerateHexColorCode;
    }
}
