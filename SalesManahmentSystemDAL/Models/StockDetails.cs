namespace SalesManahmentSystemDAL.Models
{
    public class StockDetails
    {
        public enum enType
        {
            Sale,
            Purchase,
            Expense
        }
        public int ID { get; set; }
        public int StockID { get; set; }
        public enType Type { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public int OrderID { get; set; }
        public StockDetails (int stockID, enType type, decimal total, DateTime date, int OrderID)
        {
            StockID = stockID;
            Type = type;
            Total = total;
            Date = date;
            this.OrderID = OrderID;
        }
        public StockDetails(int iD, int stockID, enType type, decimal total, DateTime date, int OrderID):
            this(stockID, type, total, date, OrderID)
        {
            ID = iD;
        }
    }
}
