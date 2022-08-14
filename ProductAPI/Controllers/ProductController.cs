using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        private List<Product> products;
        public ProductController()
        {
            products = DataModelGeneration.ProductGenerate();
        }
        [HttpGet]
        public IEnumerable<Product> ProductList()
        {
            var productList = products;
            return productList;
        }
        [HttpGet("{id}")]
        public Product GetProductById(int id)
        {
            return products.SingleOrDefault(x => x.ProductId == id, new Product());
        }
        [HttpPost]
        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
        }
        [HttpPut]
        public Product UpdateProduct(Product product)
        {
            var prod = products.SingleOrDefault(x => x.ProductId == product.ProductId);
            products.Remove(prod);
            products.Add(product);
            return product;
        }
        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            var product = products.SingleOrDefault(p => p.ProductId == id);
            products.Remove(product);
            return true;
        }
    }
}
