namespace SalesManahmentSystemBLL.DTOs
{
    public class LoginBasicDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public LoginBasicDTO(string  UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
    }
}
