using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;
using System.Text;

namespace SalesManahmentSystemBLL.Services
{
    public class SaleOrderProductService

    {
        public static IEnumerable<SalesOrderReadProductDTO> GetSaleOrderProductByNameOrID<T>(T nameOrID)
{
    string query = @"
    SELECT 
        SO.ID AS SalesOrderID, 
        C.NAME AS CUSTOMERNAME, 
        p.NAME AS PRODUCTNAME, 
        SOP.PRODUCTQUANTITY, 
        SOP.PRODUCTPRICE, 
        SOP.PRODUCTTOTALPRICE
    FROM SALEORDERS SO 
    INNER JOIN CUSTOMERS C ON SO.CUSTOMERID = C.ID
    INNER JOIN SALEORDERPRODUCTS SOP ON SOP.ORDERID = SO.ID 
    INNER JOIN PRODUCTS p ON p.ID = SOP.PRODUCTID 
    WHERE C.NAME LIKE @NameOrID 
       OR CAST(SO.ID AS VARCHAR) = @ExactID";

    return DataBaseHelper.ExecuteSelect<SalesOrderReadProductDTO>(
        query,
        new
        {
            NameOrID = $"%{nameOrID}%", // for LIKE
            ExactID = nameOrID         // for ID match
        });
}
        public static IEnumerable<SalesOrderReadProductDTO> GetSaleOrderProductByDate(DateTime from, DateTime to)
        {
            string query = @"
        SELECT 
            SO.ID AS SalesOrderID, 
            C.NAME AS CustomerName, 
            p.NAME AS ProductName, 
            SOP.PRODUCTQUANTITY AS ProductQuantity, 
            SOP.PRODUCTPRICE AS ProductPrice, 
            SOP.PRODUCTTOTALPRICE AS ProductTotalPrice
        FROM SALEORDERS SO 
        INNER JOIN CUSTOMERS C ON SO.CUSTOMERID = C.ID
        INNER JOIN SALEORDERPRODUCTS SOP ON SOP.ORDERID = SO.ID 
        INNER JOIN PRODUCTS p ON p.ID = SOP.PRODUCTID 
        WHERE SO.DATEORDER BETWEEN @FromDate AND @ToDate";

            // Pass the dates as a parameters object
            return DataBaseHelper.ExecuteSelect<SalesOrderReadProductDTO>(query, new
            {
                FromDate = from,
                ToDate = to
            });
        }
        public static string InsertSaleOrderProductsGetCommand(List<SaleOrderProduct> saleOrderProducts)
        {
            StringBuilder commandBuilder = new StringBuilder();
            foreach (var item in saleOrderProducts)
            {
                string command = 
$"({item.ProductPrice}, {item.ProductQuantity}, {item.ProductTotalPrice}, {item.OrderID}, {item.ProductID}),"; 
               commandBuilder.Append(command);
            }
            string cmd = commandBuilder.ToString().TrimEnd(',');
            return 
$"INSERT INTO SaleOrderProducts (PRODUCTPRICE, PRODUCTQUANTITY, PRODUCTTOTALPRICE, ORDERID, PRODUCTID) VALUES {cmd};";
        }
    }
}
