using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL;
using SalesManahmentSystemDAL.Models;
using System.Data;
using SalesManahmentSystemBLL.ServicesInterface;

namespace SalesManahmentSystemBLL.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            IEnumerable<Customer> Customers = 
               await DataBaseHelper.Instance.ExecuteSelect<Customer>
                ("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS");
            return Customers;
        }
        public async Task<IEnumerable<Customer>> GetAllCustomersByPattern(string pattern)
        {
            IEnumerable<Customer> Customers =
              await  DataBaseHelper.Instance.ExecuteSelect<Customer>
("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS WHERE NAME LIKE @Pattern OR CAST(ID AS VARCHAR) LIKE @Pattern",
                new { Pattern = $"%{pattern}%" });
            return Customers;
        }
        public async Task<IEnumerable<CustomerReadBasicDTO>> GetAllBasicCustomers()
        {
            IEnumerable<CustomerReadBasicDTO> Customers = 
              await  DataBaseHelper.Instance.ExecuteSelect<CustomerReadBasicDTO>("SELECT ID, Name FROM Customers");
            return Customers;
        }
        public async Task<Customer?> GetCustomerByID(int customerID)
        {
            IEnumerable<Customer> customers =
              await  DataBaseHelper.Instance.ExecuteSelect<Customer>
                ("SELECT ID, NAME, PHONENUMBER, ADDRESS, BIRTHDATE FROM CUSTOMERS WHERE ID = @ID",
                new { ID = customerID });
            return customers.FirstOrDefault();
        }
        public async Task<bool> AddCustomer(Customer Customer)
        {
            string command = @"INSERT INTO CUSTOMERS (NAME, PHONENUMBER, ADDRESS, BIRTHDATE)
VALUES (@Name, @PhoneNumber, @Address, @BirthDate)";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command,
            new
            {
                Name =Customer.Name, 
                PhoneNumber = Customer.PhoneNumber, 
                Address = Customer.Address,
                BirthDate = Customer.BirthDate
            });
            return affectedRows > 0;
        }
        public async Task<bool> UpdateCustomer(Customer Customer)
        {
            string command = @"UPDATE CUSTOMERS SET NAME = @Name, PHONENUMBER = @PhoneNumber, ADDRESS = @Address,
BIRTHDATE = @BirthDate WHERE ID = @ID";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command,
            new
            {
                ID = Customer.ID,
                Name =  Customer.Name ,
                PhoneNumber = Customer.PhoneNumber,
                Address =  Customer.Address ,
                BirthDate = Customer.BirthDate
            });
            return affectedRows > 0;
        }
        public async Task<bool> DeleteCustomer(int CustomerId)
        {
            string command = @"DELETE FROM CUSTOMERS WHERE ID = @ID";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command, new { ID = CustomerId});
            return affectedRows > 0;
        }
        public async Task<bool> DeleteAllCustomer()
        {
            string command = "DELETE FROM CUSTOMERS";
            int affectedRows = await DataBaseHelper.Instance.ExecuteDML(command);
            return affectedRows > 0;
        }
    }
}
