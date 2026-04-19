using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class CustomerService
    {
        public static IEnumerable<Customer> GetAllCustomers()
        {
            IEnumerable<Customer> Customers = 
                DataBaseHelper.ExecuteSelect<Customer>
                ("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS");
            return Customers;
        }
        public static IEnumerable<Customer> GetAllCustomersByPattern(string pattern)
        {
            IEnumerable<Customer> Customers =
                DataBaseHelper.ExecuteSelect<Customer>
("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS WHERE NAME LIKE @Pattern OR CAST(ID AS VARCHAR) LIKE @Pattern",
                new { Pattern = $"%{pattern}%" });
            return Customers;
        }
        public static IEnumerable<CustomerReadBasicDTO> GetAllBasicCustomers()
        {
            IEnumerable<CustomerReadBasicDTO> Customers = 
                DataBaseHelper.ExecuteSelect<CustomerReadBasicDTO>("SELECT ID, Name FROM Customers");
            return Customers;
        }
        public static Customer? GetCustomerByID(int customerID)
        {
            IEnumerable<Customer> customers =
                DataBaseHelper.ExecuteSelect<Customer>
                ("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS WHERE ID = @ID",
                new { ID = customerID });
            return customers.FirstOrDefault();
        }
        public static bool AddCustomer(Customer Customer)
        {
            string command = @"INSERT INTO CUSTOMERS (NAME, PHONENUMBER, ADDRESS, BIRTHDATE)
VALUES (@Name, @PhoneNumber, @Address, @BirthDate)";
            int affectedRows = DataBaseHelper.ExecuteDML(command,
            new
            {
                Name ="N'" + Customer.Name + "'", 
                PhoneNumber = Customer.PhoneNumber, 
                Address = "N'" + Customer.Address + "'",
                BirthDate = Customer.BirthDate
            });
            return affectedRows > 0;
        }
        public static bool UpdateCustomer(Customer Customer)
        {
            string command = @"UPDATE CUSTOMERS SET NAME = @Name, PHONENUMBER = @PhoneNumber, ADDRESS = @Address,
BIRTHDATE = @BirthDate WHERE ID = @ID";
            int affectedRows = DataBaseHelper.ExecuteDML(command,
            new
            {
                ID = Customer.ID,
                Name = "N'" + Customer.Name + "'",
                PhoneNumber = Customer.PhoneNumber,
                Address = "N'" + Customer.Address + "'",
                BirthDate = Customer.BirthDate
            });
            return affectedRows > 0;
        }
        public static bool DeleteCustomer(int CustomerId)
        {
            string command = @"DELETE FROM CUSTOMERS WHERE ID = @ID";
            int affectedRows = DataBaseHelper.ExecuteDML(command, new { ID = CustomerId});
            return affectedRows > 0;
        }
        public static bool DeleteAllCustomer()
        {
            string command = "DELETE FROM CUSTOMERS";
            int affectedRows = DataBaseHelper.ExecuteDML(command);
            return affectedRows > 0;
        }
    }
}
