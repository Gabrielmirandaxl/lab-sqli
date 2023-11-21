
using lab_sqli.Interfaces;
using lab_sqli.Models;

namespace lab_sqli.Services
{
    public class ProductsService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductsService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductSearch(string search)
        {
            return await _productRepository.GetAllProductSearch(search);
        }

    }
}