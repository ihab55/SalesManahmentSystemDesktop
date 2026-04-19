using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManahmentSystemBLL.DTOs
{
    public class SalesOrderReadProductDTO
    {
        public int SalesOrderID { get; set; }
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public SalesOrderReadProductDTO() { }
        public SalesOrderReadProductDTO(int salesOrderID, string cutomerName, string productName, 
            decimal productPrice, double productQuantity, decimal productTotalPrice)
        {
            SalesOrderID = salesOrderID;
            CustomerName = cutomerName;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            ProductTotalPrice = productTotalPrice;
        }
    }
}
