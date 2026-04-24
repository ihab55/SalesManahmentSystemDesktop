using Microsoft.Win32;
using SalesManahmentSystemBLL.DTOs;
using SalesManahmentSystemBLL.ServicesInterface;
using SalesManahmentSystemDAL;
using System.Data;

namespace SalesManahmentSystemBLL.Services
{
    public class LoginService : ILoginService
    {
        public bool GetStoredCredential(LoginBasicDTO Login)
        {
            bool IsSave = false;
            string SubKeypath = @"HKEY_CURRENT_USER\SOFTWARE\SMSD";
            try
            {
                if (OperatingSystem.IsWindows())
                {
                    Login.UserName = Convert.ToString(Registry.GetValue
                    (SubKeypath, "UserName", Login.UserName)) ?? string.Empty;
                    Login.Password = Convert.ToString(Registry.GetValue
                        (SubKeypath, "Password", Login.Password)) ?? string.Empty;
                    IsSave = true;
                }
            }
            catch (Exception ex) { ex.LogEvent() ; IsSave = false; }
            return IsSave;
        }

        public async Task<bool> Login(LoginBasicDTO Login)
        {
            
           return Convert.ToBoolean( await DataBaseHelper.Instance.QuerySingleOrDefualt<bool>
                ("SELECT 1 FROM USERS WHERE USERNAME = @USERNAME AND PasswordHash = @PASSWORD",
                new { USERNAME = Login.UserName, PASSWORD = Login.Password.ComputeHash() }
                ));
        }

        public bool SaveRememberMeCredentials(LoginBasicDTO Login)
        {
            bool IsSave = false;
            string SubKeypath = @"HKEY_CURRENT_USER\SOFTWARE\SMSD";
            try
            {
                if (OperatingSystem.IsWindows())
                {
                    Registry.SetValue(SubKeypath, "UserName",
                        Login.UserName, RegistryValueKind.String);
                    Registry.SetValue(SubKeypath, "Password",
                        Login.Password, RegistryValueKind.String);
                    IsSave = true;
                }
            }
            catch (Exception ex) { ex.LogEvent(); IsSave = false; }
            return IsSave;
        }
    }
}
