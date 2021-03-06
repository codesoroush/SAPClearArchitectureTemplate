﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime? StartWorkTime { get; set; } = DateTime.Now;
        public DateTime? EndWorkTime { get; set; } = DateTime.Now;
        public string  CompanyUserName  { get; set; } = System.Text.RegularExpressions.Regex.Replace(Convert.ToBase64String(Guid.NewGuid().ToByteArray()), "[/+=]", "");
        public List<TodoItemCategory> CompanyCategories { get; set; } = new List<TodoItemCategory>();

        public string LimitedProviderName { get; set; }
        public string LimitedIpRange { get; set; }
        public string LimitedCountry {get; set; }
        public string NoteOfTheDay { get; set; }


        public ApplicationUser Creator { get; set; }


    }
}
