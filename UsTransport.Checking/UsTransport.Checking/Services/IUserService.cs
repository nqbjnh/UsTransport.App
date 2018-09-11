using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IUserService
    {
       
        Response Login(string Email,string Password);
        string GetToken(string Username,string Password);
        Task<Response> GetRoleMenu(int UserId);
        
    }
}