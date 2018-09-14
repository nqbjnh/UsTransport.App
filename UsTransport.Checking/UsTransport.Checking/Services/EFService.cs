using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsTransport.Checking.Databases;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Services
{
    public class EfService : IEFService
    {
        private readonly DatabaseContext _databaseContext;
        public EfService()
        {
            _databaseContext = new DatabaseContext();
        }
        public User GetUser()
        {
            try
            {
                return _databaseContext.Users.FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<User> GetUserAsync()
        {
            return await _databaseContext.Users.FirstAsync();
        }

        public int DeleteUser(User user)
        {
            return DeleteUserAsync(user).Result;
        }

        public async Task<int> DeleteUserAsync(User user)
        {
            _databaseContext.Users.Remove(user);
            return await _databaseContext.SaveChangesAsync();
        }

        public int SaveUser(User user)
        {
            return SaveUserAsync(user).Result;
        }

        public async Task<int> SaveUserAsync(User user)
        {
            if (user.Id == 0)
            {
                await _databaseContext.Users.AddAsync(user);
            }
            return await _databaseContext.SaveChangesAsync();
        }
    }
}