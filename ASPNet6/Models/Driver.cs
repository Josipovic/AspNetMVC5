using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNet6.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
        public bool Hired { get; set; }
    }
}