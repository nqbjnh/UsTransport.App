using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsTransport.Checking.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public int Enviroment { get; set; }
        public string Roles { get; set; }

        [NotMapped]
        public List<int> RoleMenus { get; set; }
    }
}