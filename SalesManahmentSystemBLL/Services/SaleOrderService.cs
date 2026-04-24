using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;
using SalesManahmentSystemBLL.ServicesInterface;

namespace SalesManahmentSystemBLL.Services
{
    public class SaleOrderService : ISaleOrderService
    {
        public async Task<int> GetLastID()
        {
            string query = "SELECT ISNULL(MAX(ID),0) AS LastOrderID FROM SaleOrders";
            int LastOrderID = await DataBaseHelper.Instance.QuerySingleOrDefualt<int>(query);
            return LastOrderID;
        }

        public async Task<bool> InsertSalesOrderTransaction(SaleOrder order, List<SaleOrderProduct> saleOrderProducts,
            List<Product> products, Stock stock, StockDetails stockDetails)
        {
            List<string> commands = new List<string>();
            
            // Insert SaleOrder Command
            string InsertSaleOrderCommand = InsertSaleOrderGetCommand(order);
            commands.Add(InsertSaleOrderCommand);

            // Insert SaleOrderProducts Commands
            var saleOrderProductService = new SaleOrderProductService();
            string InsertSaleOrderProductsCommand = saleOrderProductService.InsertSaleOrderProductsGetCommand(saleOrderProducts);
            commands.Add(InsertSaleOrderProductsCommand);

            // Update Products Quantity Commands
            var productService = new ProductService();
            string UpdateProductsQuantityCommand = productService.UpdateProductsQuantityGetCommand(products);
            commands.Add(UpdateProductsQuantityCommand);

            // Update Stock TotalMoney Command
            var stockService = new StockService();
            string UpdateStockTotalMoneyCommand = stockService.UpdateStockTotalMoneyGetCommand(stock);
            commands.Add(UpdateStockTotalMoneyCommand);

            // Insert StockDetails Command
            var stockDetailsService = new StockDetailsService();
            string InsertStockDetailsCommand = stockDetailsService.InsertStockDetailsGetCommand(stockDetails);
            commands.Add(InsertStockDetailsCommand);

            return await DataBaseHelper.Instance.ExecuteTransaction(commands);

        }
        public string InsertSaleOrderGetCommand(SaleOrder order)
        {
            return $@"INSERT INTO SaleOrders (ID, CUSTOMERID, TOTALORDER, DATEORDER) 
VALUES ({order.ID}, {order.CustomerID}, {order.TotalOrder}, '{order.DateOrder:yyyy-MM-dd}');";
        }
    }
}
