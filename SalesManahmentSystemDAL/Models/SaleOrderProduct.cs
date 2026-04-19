namespace SalesManahmentSystemDAL.Models
{
    public class SaleOrderProduct
    {
        public decimal ProductPrice { get; set; }
        public double ProductQuantity { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        
        public SaleOrderProduct(decimal productPrice, double productQuantity, decimal productTotalPrice, int productID, int orderID)
        {
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
            ProductTotalPrice = productTotalPrice;
            ProductID = productID;
            OrderID = orderID;
        }
    }
}
