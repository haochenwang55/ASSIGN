using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_code.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Studentid { get; set;  }
        public virtual Student Student { get; set; }
    }
}