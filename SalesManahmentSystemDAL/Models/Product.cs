using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManahmentSystemDAL.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public double Quantity { get; set; }
        public int CategoryID { get; set; }
        public Product(int ID, string Name, decimal BuyPrice, decimal SalePrice, double Quantity, int CategoryID)
        {
            this.ID = ID;
            this.Name = Name;
            this.BuyPrice = BuyPrice;
            this.SalePrice = SalePrice;
            this.Quantity = Quantity;
            this.CategoryID = CategoryID;
        }
    }
}
