using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Entity
{
    public class Product:DbContext
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public string ProductStock { get; set; }
        public string Details { get; set; }
        public Category Category { get; set; }
    }
}
