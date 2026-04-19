using SalesManahmentSystemBLL.DTOs;
using System.Text;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class ProductService
    {
        public static IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> Products = 
                DataBaseHelper.ExecuteSelect<Product>("SELECT * FROM PRODUCTS");
            
            return Products;
        }
        public static IEnumerable<ProductReadBasicDTO> GetAllBasicProducts()
        {
            IEnumerable<ProductReadBasicDTO> Products = 
                DataBaseHelper.ExecuteSelect<ProductReadBasicDTO>("SELECT ID, NAME FROM PRODUCTS");
            return Products;
        }
        public static string UpdateProductsQuantityGetCommand(List<Product> products)
        {
            StringBuilder commandBuilder = new StringBuilder();
            foreach (var product in products)
            {
                commandBuilder.Append($"UPDATE PRODUCTS SET Quantity = Quantity - {product.Quantity} WHERE ID = {product.ID};");
            }
            return commandBuilder.ToString();
        }
        public static IEnumerable<Product> GetAllProductsByPattern(string pattern)
        {
            string WarrpedPattern = $"%{pattern}%";
            IEnumerable<Product> Products = 
                DataBaseHelper.ExecuteSelect<Product>
                ("SELECT * FROM PRODUCTS WHERE NAME LIKE @Pattern OR CAST(ID AS VARCHAR) LIKE @Pattern", 
                new { Pattern = WarrpedPattern });
            return Products;
        }
        public static Product? GetProductByID(int productID)
        {
            return
 DataBaseHelper.QuerySingleOrDefualt<Product>
 ("SELECT * FROM PRODUCTS WHERE ID = @ProductID", new {ProductID = productID});
        }
        public static bool AddProduct(Product Product)
        {
            string command = 
                $@"INSERT INTO PRODUCTS (Name, BuyPrice, SalePrice ,Quantity, CategoryID) 
                VALUES (N'{Product.Name}', {Product.BuyPrice}, {Product.SalePrice}, {Product.Quantity}, {Product.CategoryID})";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
        public static bool UpdateProduct(Product Product)
        {
            string command = $@"UPDATE PRODUCTS SET 
Name = N'{Product.Name}', BuyPrice =  {Product.BuyPrice}, SalePrice = {Product.SalePrice}, Quantity = {Product.Quantity}
WHERE ID = {Product.ID}";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
        public static bool DeleteProduct(int ProductId)
        {
            string command = $"DELETE FROM PRODUCTS WHERE ID = {ProductId}";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
        public static bool DeleteAllProduct()
        {
            string command = "DELETE FROM PRODUCTS";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
    }
}
