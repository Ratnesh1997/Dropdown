using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dropdown.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
      public  DbSet<Emp1>emp1s { get; set; }

        public DbSet<Country> countries { get; set; }

        public DbSet<State> states { get; set; }

        public DbSet<Registration> registrations { get; set; }

    }

    }
