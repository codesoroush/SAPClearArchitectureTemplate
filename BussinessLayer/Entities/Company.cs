using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartWorkTime { get; set; }
        public DateTime EndWorkTime { get; set; }

        public string LimitedProviderName { get; set; }
        public string LimitedIpRange { get; set; }
        public string LimitedCountry {get; set; }
        public string NoteOfTheDay { get; set; }


    }
}
