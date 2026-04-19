namespace SalesManahmentSystemBLL.DTOs
{
    public class StockDetailsDTO
    {
        public int ID { get; set; }
        public string StockName { get; set; }
        public int TypeInt { get; set; }
        public string TypeName
        {
            get
            {
                return TypeInt switch
                {
                    0 => "بيع",
                    1 => "شراء",
                    2 => "مصروفات",
                    _ => "غير معروف"
                };
            }
        }
        public decimal TOTAL { get; set; }
        public DateTime DATE { get; set; }
        public int ORDERID { get; set; }
    }
}
