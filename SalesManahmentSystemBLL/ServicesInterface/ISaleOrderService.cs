using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface ISaleOrderService
    {
        Task<int >GetLastID();
        Task<bool> InsertSalesOrderTransaction(SaleOrder order, List<SaleOrderProduct> saleOrderProducts,
           List<Product> products, Stock stock, StockDetails stockDetails);
        string InsertSaleOrderGetCommand(SaleOrder order);
    }
}
