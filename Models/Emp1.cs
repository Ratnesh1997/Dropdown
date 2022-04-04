using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
    public class Emp1
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Sur_Name { get; set; }

        public string Gender { get; set; }
        public string Age { get; set; }
        //public string State { get; set; }

        public string Mobile { get; set; }
        public string Address { get; set; }
        public State s { get; set; }
        public Country c { get; set; }

    }
}
