﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneApplicaton.Models
{
    public class DataContext:DbContext
    {
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public object Manufacturer { get; internal set; }
    }
}