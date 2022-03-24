using BlazorApp.Shared.Models;

namespace BlazorApp.Server.Interfaces
{
    public interface IProduct
    {
        public List<Product> GetProductDetails();

        public void AddProduct(Product product);

        public void UpdateProductDetails(Product product);

        public Product GetProductData(int id);

        public void DeleteProduct(int id);
    }
}
