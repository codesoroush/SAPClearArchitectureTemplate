using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class EnterInfo
    {
        public int Id { get; set; }
        public string IP { get; set; }
        public string Country { get; set; }
        public string Organization { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string UserAgent { get; set; }

        #region relations
        public int AbsenceId { get; set; }
        public Absence Absence { get; set; }

        #endregion

    }
}
