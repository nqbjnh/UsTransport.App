using System.Threading.Tasks;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public interface IEFService
    {
        User GetUser();
        Task<User> GetUserAsync();
        int DeleteUser(User user);
        Task<int> DeleteUserAsync(User user);
        int SaveUser(User user);
        Task<int> SaveUserAsync(User user);
        
    }
}