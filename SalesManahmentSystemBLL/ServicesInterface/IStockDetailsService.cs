using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface IStockDetailsService
    {
        string InsertStockDetailsGetCommand(StockDetails stockDetails);
        Task<IEnumerable<StockDetailsDTO>> GetAllStockDetails();
        Task<IEnumerable<StockDetailsDTO>> GetStockDetailsByStockID(int stockID);
        Task<IEnumerable<StockDetailsDTO>> GetStockDetailsByDateRange(DateTime fromDate, DateTime toDate);
        Task<IEnumerable<StockDetailsDTO>> GetStockDetailsByType(StockDetails.enType type);
    }
}
