namespace SalesManahmentSystemDAL.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal TotalMoney { get; set; }
        public Stock(string name, decimal totalMoney)
        {
            this.Name = name;
            this.TotalMoney = totalMoney;
        }
        public Stock(int ID, string name, decimal totalMoney) : this(name, totalMoney)
        {
            this.ID = ID;
        }
        public Stock() { }
    }
}
