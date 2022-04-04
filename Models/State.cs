using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdown.Models
{
    public class State
    {
        [Key]
        public int s_id { get; set; }

        public string s_name { get; set; }

        public Country country { get; set; }
    }
}
