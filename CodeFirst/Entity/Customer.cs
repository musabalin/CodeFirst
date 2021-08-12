using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerTitle { get; set; }
        public string City { get; set; }
    }
}
