namespace SalesManahmentSystemDAL.Models
{
    public class SaleOrder
    {
        public int ID { get; set; }
        public DateTime DateOrder { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalOrder { get; set; }
        public SaleOrder(int iD, DateTime dateOrder, int customerID, decimal totalOrder)
        {
            ID = iD;
            DateOrder = dateOrder;
            CustomerID = customerID;
            TotalOrder = totalOrder;
        }
    }
}
