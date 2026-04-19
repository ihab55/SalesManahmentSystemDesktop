namespace SalesManahmentSystemDAL.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category() { }
        public Category(int ID,string name)
        {
            this.ID = ID;
            this.Name = name;
        }
    }
}
