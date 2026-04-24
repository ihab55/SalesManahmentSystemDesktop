using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;
using SalesManahmentSystemBLL.ServicesInterface;
using SalesManahmentSystemBLL.DTOs;

namespace SalesManahmentSystemBLL.Services
{
    public class StockService : IStockService
    {
        public string UpdateStockTotalMoneyGetCommand(Stock stock)
        {
            return $"UPDATE STOCKS SET TotalMoney = TotalMoney + {stock.TotalMoney} WHERE ID = {stock.ID};";
        }
        public async Task<bool> AddStock(Stock NewStock)
        {
            int AffecttedRow = await DataBaseHelper.Instance.ExecuteDML
                ("INSERT INTO STOCKS ( NAME, TOTALMONEY) VALUES ( @Name, @TotalMoney)"
                , new
                {
                    Name =  NewStock.Name ,
                    TotalMoney = NewStock.TotalMoney
                });
            return AffecttedRow > 0;
        }
        public async Task<IEnumerable<Stock>> GetAllStocks()
        {
            return await DataBaseHelper.Instance.ExecuteSelect<Stock>("SELECT * FROM STOCKS");
        }
        public async Task<IEnumerable<Stock>> GetAllStocksByPattern(string pattern)
        {
            string WarrpedPattern = $"%{pattern}%";
            IEnumerable<Stock> Products =
               await DataBaseHelper.Instance.ExecuteSelect<Stock>
                ("SELECT * FROM STOCKS WHERE NAME LIKE @Pattern OR CAST(ID AS VARCHAR) LIKE @Pattern",
                new { Pattern = WarrpedPattern });
            return Products;
        }
        public async Task<bool> UpdateStock(Stock stock)
        {
            int AffecttedRow = await DataBaseHelper.Instance.ExecuteDML
                ("UPDATE STOCKS SET NAME = @Name, TOTALMONEY = @TotalMoney WHERE ID = @ID"
                , new
                {
                    ID = stock.ID,
                    Name = stock.Name,
                    TotalMoney = stock.TotalMoney
                });
            return AffecttedRow > 0;
        }
        public async Task<bool> DeleteStock(int ID)
        {
            int AffecttedRow = await DataBaseHelper.Instance.ExecuteDML
                ("DELETE FROM STOCKS WHERE ID = @ID"
                , new { ID });
            return AffecttedRow > 0;
        }
        public async Task<bool> DeleteAllStocks()
        {
            int AffectedRows = await DataBaseHelper.Instance.ExecuteDML("DELETE FROM STOCKS");
            return AffectedRows > 0;
        }

        public async Task<IEnumerable<StockBasicDTO>> GetAllBasicStocks()
        {
            string query = "SELECT ID, NAME as Name FROM STOCKS ORDER BY NAME";
            return await DataBaseHelper.Instance.ExecuteSelect<StockBasicDTO>(query);
        }
    }
}
