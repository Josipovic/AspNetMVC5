using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASPNet6.Models
{
    public class DriverContext:DbContext
    {
        public DbSet<Driver> Drivers { get; set; }
    }
}