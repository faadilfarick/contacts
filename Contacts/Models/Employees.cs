using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacts.Models
{
    public class Employees
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Position { get; set; }
        
        public string Office { get; set; }
        
        public int Age { get; set; }
        
        public DateTime StartDate { get; set; }
    }
}