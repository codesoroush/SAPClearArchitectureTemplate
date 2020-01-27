using BussinessLayer.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class DailyLeaves
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public AbsenceMode AbsenceMode { get; set; }


        #region Relations
        public int AbsenceId { get; set; }
        public Absence Absence { get; set; }
        #endregion

    }
}
