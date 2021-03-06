﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Entities
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public string LastModifiedBy { get; set; }

        public DateTime? LastModified { get; set; }
    }
}
