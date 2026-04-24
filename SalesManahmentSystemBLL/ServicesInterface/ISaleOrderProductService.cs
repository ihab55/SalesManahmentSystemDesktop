using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface ISaleOrderProductService
    {
        Task<IEnumerable<SalesOrderReadProductDTO>> GetSaleOrderProductByNameOrID<T>(T nameOrID);
        Task<IEnumerable<SalesOrderReadProductDTO>> GetSaleOrderProductByDate(DateTime from, DateTime to);
        string InsertSaleOrderProductsGetCommand(List<SaleOrderProduct> saleOrderProducts);
    }
}
