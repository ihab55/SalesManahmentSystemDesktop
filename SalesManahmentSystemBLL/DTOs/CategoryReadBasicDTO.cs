namespace SalesManahmentSystemBLL.DTOs
{
    public class CategoryReadBasicDTO
    {
        public CategoryReadBasicDTO(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
