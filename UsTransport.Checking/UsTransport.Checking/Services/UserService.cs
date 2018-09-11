using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using UsTransport.Checking.Models;
using UsTransport.Checking.Utils;

namespace UsTransport.Checking.Services
{
    public class UserService : IUserService
    {
        public Response Login(string Email, string Password)
        {
            try
            {
                var response = Client.PostByTokenAsync<Response>(App.APPCONFIG.Api + "/api/app/login",new {Email = Email,Password = Password}.ToJson()).Result;
                return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetToken(string Username, string Password)
        {
            try
            {
                
                var token = Client.GetToken(App.APPCONFIG.Api + "/token", Username,Password);
                return token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<Response> GetRoleMenu(int UserId)
        {
            throw new System.NotImplementedException();
        }
    }
}