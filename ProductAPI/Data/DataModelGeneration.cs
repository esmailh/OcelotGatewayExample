using ProductAPI.Models;

namespace ProductAPI.Data
{
    public static class DataModelGeneration
    {
        public static List<Product> ProductGenerate()
        {
            var output = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                Product product = new Product();
                product.ProductDescription = $"ProductDescription{i}";
                product.ProductId = i;
                product.ProductName = $"ProductName{i}";
                product.ProductPrice = i + 100;
                product.ProductStock = i + 500;
                output.Add(product);
            }
            return output;
        }
    }
}
