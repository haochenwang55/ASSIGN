using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week4_code.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public virtual ICollection<Unit> Units { get; set;  }
    }
}