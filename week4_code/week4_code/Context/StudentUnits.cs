using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using week4_code.Models;

namespace week4_code.Context
{
    public class StudentUnits : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }

    }
}