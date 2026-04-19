using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class StockDetailsService
    {
        public static string InsertStockDetailsGetCommand(StockDetails stockDetails)
        {
            return $@"INSERT INTO StockDetails (STOCKID, TYPE, TOTAL, DATE, ORDERID)
VALUES ({stockDetails.StockID}, {(int)stockDetails.Type}, {stockDetails.Total}, '{stockDetails.Date:yyyy-MM-dd}', {stockDetails.OrderID});";
        }

        public static IEnumerable<StockDetailsDTO> GetAllStockDetails()
        {
            string query = @"
                SELECT 
                    sd.ID,
                    s.NAME as StockName,
                    sd.TYPE as TypeInt,
                    sd.TOTAL,
                    sd.DATE,
                    sd.ORDERID
                FROM STOCKDETAILS sd
                INNER JOIN STOCKS s ON sd.STOCKID = s.ID
                ORDER BY sd.DATE DESC";
            return DataBaseHelper.ExecuteSelect<StockDetailsDTO>(query);
        }

        public static IEnumerable<StockDetailsDTO> GetStockDetailsByStockID(int stockID)
        {
            string query = @"
                SELECT 
                    sd.ID,
                    s.NAME as StockName,
                    sd.TYPE as TypeInt,
                    sd.TOTAL,
                    sd.DATE,
                    sd.ORDERID
                FROM STOCKDETAILS sd
                INNER JOIN STOCKS s ON sd.STOCKID = s.ID
                WHERE sd.STOCKID = @StockID
                ORDER BY sd.DATE DESC";
            return DataBaseHelper.ExecuteSelect<StockDetailsDTO>(query, new { StockID = stockID });
        }

        public static IEnumerable<StockDetailsDTO> GetStockDetailsByDateRange(DateTime fromDate, DateTime toDate)
        {
            string query = @"
                SELECT 
                    sd.ID,
                    s.NAME as StockName,
                    sd.TYPE as TypeInt,
                    sd.TOTAL,
                    sd.DATE,
                    sd.ORDERID
                FROM STOCKDETAILS sd
                INNER JOIN STOCKS s ON sd.STOCKID = s.ID
                WHERE sd.DATE BETWEEN @FromDate AND @ToDate
                ORDER BY sd.DATE DESC";
            return DataBaseHelper.ExecuteSelect<StockDetailsDTO>(query, new { FromDate = fromDate, ToDate = toDate });
        }

        public static IEnumerable<StockDetailsDTO> GetStockDetailsByType(StockDetails.enType type)
        {
            string query = @"
                SELECT 
                    sd.ID,
                    s.NAME as StockName,
                    sd.TYPE as TypeInt,
                    sd.TOTAL,
                    sd.DATE,
                    sd.ORDERID
                FROM STOCKDETAILS sd
                INNER JOIN STOCKS s ON sd.STOCKID = s.ID
                WHERE sd.TYPE = @Type
                ORDER BY sd.DATE DESC";
            return DataBaseHelper.ExecuteSelect<StockDetailsDTO>(query, new { Type = (int)type });
        }
    }
}
