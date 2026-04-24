using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface IStockService
    {
        string UpdateStockTotalMoneyGetCommand(Stock stock);
        Task<bool> AddStock(Stock newStock);
        Task<IEnumerable<Stock>> GetAllStocks();
        Task<IEnumerable<Stock>> GetAllStocksByPattern(string pattern);
        Task<bool> UpdateStock(Stock stock);
        Task<bool> DeleteStock(int id);
        Task<bool> DeleteAllStocks();
        Task<IEnumerable<StockBasicDTO>> GetAllBasicStocks();
    }
}
