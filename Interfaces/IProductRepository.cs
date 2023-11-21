using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_sqli.Models;

namespace lab_sqli.Interfaces
{
    public interface IProductRepository
    {
       Task<IEnumerable<Product>> GetAllProductSearch(string search);
    }
}