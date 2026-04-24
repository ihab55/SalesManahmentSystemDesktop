using SalesManahmentSystemBLL.DTOs;
using System.Text;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;
using SalesManahmentSystemBLL.ServicesInterface;

namespace SalesManahmentSystemBLL.Services
{
    public class ProductService : IProductService
    {
        public async Task<IEnumerable<ProductsViewDTO>> GetAllProducts()
        {
            IEnumerable<ProductsViewDTO> Products = 
              await  DataBaseHelper.Instance.ExecuteSelect<ProductsViewDTO>
 (@"SELECT P.ID, P.NAME, BUYPRICE, SALEPRICE, QUANTITY, c.NAME AS CATEGORYNAME 
FROM PRODUCTS P INNER JOIN CATEGORYS c ON P.CATEGORYID = c.ID");
            
            return Products;
        }
        public async Task<IEnumerable<ProductsViewDTO>> GetAllProductsByPattern(string pattern)
        {
            string WarrpedPattern = $"%{pattern}%";
            IEnumerable<ProductsViewDTO> Products =
              await DataBaseHelper.Instance.ExecuteSelect<ProductsViewDTO>
                (@"SELECT P.ID, P.NAME, BUYPRICE, SALEPRICE, QUANTITY, c.NAME AS CATEGORYNAME 
FROM PRODUCTS P INNER JOIN CATEGORYS c ON P.CATEGORYID = c.ID 
WHERE P.NAME LIKE @Pattern OR CAST(P.ID AS VARCHAR) LIKE @Pattern",
                new { Pattern = WarrpedPattern });
            return Products;
        }
        public async Task<IEnumerable<ProductReadBasicDTO>> GetAllBasicProducts()
        {
            IEnumerable<ProductReadBasicDTO> Products = 
              await  DataBaseHelper.Instance.ExecuteSelect<ProductReadBasicDTO>("SELECT ID, NAME FROM PRODUCTS");
            return Products;
        }
        public string UpdateProductsQuantityGetCommand(List<Product> products)
        {
            StringBuilder commandBuilder = new StringBuilder();
            foreach (var product in products)
            {
                commandBuilder.Append($"UPDATE PRODUCTS SET Quantity = Quantity - {product.Quantity} WHERE ID = {product.ID};");
            }
            return commandBuilder.ToString();
        }
        
        public async Task<Product?> GetProductByID(int productID)
        {
            return await
 DataBaseHelper.Instance.QuerySingleOrDefualt<Product>
 ("SELECT * FROM PRODUCTS WHERE ID = @ProductID", new {ProductID = productID});
        }
        public async Task<bool> AddProduct(Product Product)
        {
            string command = 
                $@"INSERT INTO PRODUCTS (Name, BuyPrice, SalePrice ,Quantity, CATEGORYID) 
                VALUES ( @Name, @BuyPrice, @SalePrice, @Quantity, @CategoryID)";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command, new
            {
                Name = Product.Name,
                BuyPrice = Product.BuyPrice,
                SalePrice = Product.SalePrice,
                Quantity = Product.Quantity,
                CategoryID = Product.CategoryID
            });
            return affectedRows > 0;
        }
        public async Task<bool> UpdateProduct(Product Product)
        {
            string command = $@"UPDATE PRODUCTS SET 
Name = N'{Product.Name}', BuyPrice =  {Product.BuyPrice}, SalePrice = {Product.SalePrice}, Quantity = {Product.Quantity}
WHERE ID = {Product.ID}";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
        public async Task<bool> DeleteProduct(int ProductId)
        {
            string command = $"DELETE FROM PRODUCTS WHERE ID = {ProductId}";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
        public async Task<bool> DeleteAllProduct()
        {
            string command = "DELETE FROM PRODUCTS";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
    }
}
