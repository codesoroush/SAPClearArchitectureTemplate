using BussinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class Absence:BaseEntity
    {
        public int Id { get; set; }
        public DateTime? Entry { get; set; }
        public DateTime? Exit { get; set; }
        public string Description { get; set; }
        public string AdminDescription { get; set; }
        public AbsenceMode AbsenceMode { get; set; }
        public WorkPlace WorkPlace { get; set; }

        public virtual List<DailyLeaves> DailyLeaves { get; set; }


        #region Relations
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        #endregion
    }
}
