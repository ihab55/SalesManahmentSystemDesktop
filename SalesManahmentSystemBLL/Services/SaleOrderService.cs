using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class SaleOrderService
    {
        public static int GetLastID()
        {
            string query = "SELECT ISNULL(MAX(ID),0) AS LastOrderID FROM SaleOrders";
            int LastOrderID = DataBaseHelper.QuerySingleOrDefualt<int>(query);
            return LastOrderID;
        }

        public static bool InsertSalesOrderTransaction(SaleOrder order, List<SaleOrderProduct> saleOrderProducts,
            List<Product> products, Stock stock, StockDetails stockDetails)
        {
            List<string> commands = new List<string>();
            
            // Insert SaleOrder Command
            string InsertSaleOrderCommand = SaleOrderService.InsertSaleOrderGetCommand(order);
            commands.Add(InsertSaleOrderCommand);

            // Insert SaleOrderProducts Commands
            string InsertSaleOrderProductsCommand = SaleOrderProductService.InsertSaleOrderProductsGetCommand(saleOrderProducts);
            commands.Add(InsertSaleOrderProductsCommand);

            // Update Products Quantity Commands
            string UpdateProductsQuantityCommand = ProductService.UpdateProductsQuantityGetCommand(products);
            commands.Add(UpdateProductsQuantityCommand);

            // Update Stock TotalMoney Command
            string UpdateStockTotalMoneyCommand = StockService.UpdateStockTotalMoneyGetCommand(stock);
            commands.Add(UpdateStockTotalMoneyCommand);

            // Insert StockDetails Command
            string InsertStockDetailsCommand = StockDetailsService.InsertStockDetailsGetCommand(stockDetails);
            commands.Add(InsertStockDetailsCommand);

            return DataBaseHelper.ExecuteTransaction(commands);

        }
        public static string InsertSaleOrderGetCommand(SaleOrder order)
        {
            return $@"INSERT INTO SaleOrders (ID, CUSTOMERID, TOTALORDER, DATEORDER) 
VALUES ({order.ID}, {order.CustomerID}, {order.TotalOrder}, '{order.DateOrder:yyyy-MM-dd}');";
        }
    }
}
