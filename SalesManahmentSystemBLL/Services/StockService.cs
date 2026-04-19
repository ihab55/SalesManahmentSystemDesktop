using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class StockService
    {
        public static string UpdateStockTotalMoneyGetCommand(Stock stock)
        {
            return $"UPDATE STOCKS SET TotalMoney = TotalMoney + {stock.TotalMoney} WHERE ID = {stock.ID};";
        }
        public static bool AddStock(Stock NewStock)
        {
            int AffecttedRow = DataBaseHelper.ExecuteDML
                ("INSERT INTO STOCKS ( NAME, TOTALMONEY) VALUES ( @Name, @TotalMoney)"
                , new
                {
                    Name = "N'" + NewStock.Name +"'",
                    TotalMoney = NewStock.TotalMoney
                });
            return AffecttedRow > 0;
        }
        public static IEnumerable<Stock> GetAllStocks()
        {
            return DataBaseHelper.ExecuteSelect<Stock>("SELECT * FROM STOCKS");
        }
        public static IEnumerable<Stock> GetAllStocksByPattern(string pattern)
        {
            string WarrpedPattern = $"%{pattern}%";
            IEnumerable<Stock> Products =
                DataBaseHelper.ExecuteSelect<Stock>
                ("SELECT * FROM STOCKS WHERE NAME LIKE @Pattern OR CAST(ID AS VARCHAR) LIKE @Pattern",
                new { Pattern = WarrpedPattern });
            return Products;
        }
        public static bool UpdateStock(Stock stock)
        {
            int AffecttedRow = DataBaseHelper.ExecuteDML
                ("UPDATE STOCKS SET NAME = @Name, TOTALMONEY = @TotalMoney WHERE ID = @ID"
                , new
                {
                    ID = stock.ID,
                    Name = stock.Name,
                    TotalMoney = stock.TotalMoney
                });
            return AffecttedRow > 0;
        }
        public static bool DeleteStock(int ID)
        {
            int AffecttedRow = DataBaseHelper.ExecuteDML
                ("DELETE FROM STOCKS WHERE ID = @ID"
                , new { ID });
            return AffecttedRow > 0;
        }
        public static bool DeleteAllStocks()
        {
            int AffecttedRow = DataBaseHelper.ExecuteDML("DELETE FROM STOCKS");
            return AffecttedRow > 0;
        }

    }
}
