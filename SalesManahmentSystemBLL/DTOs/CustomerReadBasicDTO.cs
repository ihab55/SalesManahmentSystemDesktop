using System;
using System.Collections.Generic;
using System.Text;

namespace SalesManahmentSystemBLL.DTOs
{
    public class CustomerReadBasicDTO
    {
        public CustomerReadBasicDTO(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
