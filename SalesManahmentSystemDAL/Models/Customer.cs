namespace SalesManahmentSystemDAL.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Customer() { }
        public Customer(int id, string name, string phoneNumber, string address, DateTime birthDate): 
            this(name, phoneNumber, address, birthDate)
        {
            ID = id;
        }
        public Customer(string name, string phoneNumber, string address, DateTime birthDate)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            BirthDate = birthDate;
        }
    }
}
