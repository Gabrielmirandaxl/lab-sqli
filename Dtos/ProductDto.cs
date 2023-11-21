using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_sqli.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Product_Name { get; set; }
        public decimal Price { get; set; }
    }
}