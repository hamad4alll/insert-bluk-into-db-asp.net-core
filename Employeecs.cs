using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlukInsertcore.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
    }
}
