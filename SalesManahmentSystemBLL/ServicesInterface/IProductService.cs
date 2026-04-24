using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface IProductService
    {
        Task<IEnumerable<ProductsViewDTO>> GetAllProducts();
        Task<IEnumerable<ProductReadBasicDTO>> GetAllBasicProducts();
        string UpdateProductsQuantityGetCommand(List<Product> products);
        Task<IEnumerable<ProductsViewDTO>> GetAllProductsByPattern(string pattern);
        Task<Product?> GetProductByID(int productID);
        Task<bool> AddProduct(Product product);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(int productId);
        Task<bool> DeleteAllProduct();
    }
}
