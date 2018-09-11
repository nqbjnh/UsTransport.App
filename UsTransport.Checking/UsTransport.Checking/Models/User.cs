using System.Collections.Generic;

namespace UsTransport.Checking.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public List<int> RoleMenus { get; set; }
    }
}