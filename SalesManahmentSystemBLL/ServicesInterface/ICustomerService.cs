using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemDAL.Models;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<IEnumerable<Customer>> GetAllCustomersByPattern(string pattern);
        Task<IEnumerable<CustomerReadBasicDTO>> GetAllBasicCustomers();
        Task<Customer?> GetCustomerByID(int customerID);
        Task<bool> AddCustomer(Customer customer);
        Task<bool> UpdateCustomer(Customer customer);
        Task<bool> DeleteCustomer(int customerId);
        Task<bool> DeleteAllCustomer();
    }
}
