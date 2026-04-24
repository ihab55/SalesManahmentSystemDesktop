using SalesManahmentSystemDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManahmentSystemBLL.DTOs
{
    public class ProductsViewDTO
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public double Quantity { get; set; }
        public string CategoryName { get; set; }
        public ProductsViewDTO(int ID, string Name, decimal BuyPrice, decimal SalePrice, double Quantity, string CategoryName)
        {
            this.ID = ID;
            this.Name = Name;
            this.BuyPrice = BuyPrice;
            this.SalePrice = SalePrice;
            this.Quantity = Quantity;
            this.CategoryName = CategoryName;
        }
    }
}
