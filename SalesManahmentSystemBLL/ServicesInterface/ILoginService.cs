using SalesManahmentSystemBLL.DTOs;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public interface ILoginService
    {
        Task <bool> Login(LoginBasicDTO Login);
        bool SaveRememberMeCredentials(LoginBasicDTO Login);
        bool GetStoredCredential (LoginBasicDTO Login);

    }
}
