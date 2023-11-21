using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_sqli.Models;

namespace lab_sqli.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductSearch(string search);
   
    }
}