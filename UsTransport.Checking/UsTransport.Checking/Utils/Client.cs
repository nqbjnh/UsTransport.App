using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UsTransport.Checking.Models;

namespace UsTransport.Checking.Utils
{
    /// <summary>
    /// Author: BinhNQ
    /// </summary>
    public class Client
    {
        #region Get

        public static string _Token { get; set; }

        public static T Get<T>(string ApiUrl) where T : new()
        {
            return GetAsync<T>(ClientHelper.GetClient(), ApiUrl).Result;
        }

        public static async Task<T> GetAsync<T>(HttpClient httpClient,string ApiUrl) where T : new()
        {
            try
            {
                using (httpClient)
                {
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = httpClient.GetAsync(ApiUrl).ConfigureAwait(false).GetAwaiter().GetResult();
                    var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(responseContent);
                    }

                    return await Task.FromResult(responseContent.JsonToObject<T>()).ConfigureAwait(false);
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<T> GetAsync<T>(string ApiUrl) where T : new()
        {
            return await GetAsync<T>(ClientHelper.GetClient(),ApiUrl);
        }

        public static async Task<T> GetByTokenAsync<T>(string ApiUrl,string Token) where T : new()
        {
            return await GetAsync<T>(ClientHelper.GetClient(Token), ApiUrl);
        }

        public static async Task<T> GetByBasicAuthAsync<T>(string ApiUrl, string Username,string Password) where T : new()
        {
            return await GetAsync<T>(ClientHelper.GetClient(Username,Password), ApiUrl);
        }

        #endregion

        #region Post

        public static T Post<T>(string ApiUrl, string JsonContent) where T : new()
        {
            return PostAsync<T>(ClientHelper.GetClient(), ApiUrl, JsonContent).Result;
        }


        public static async Task<T> PostAsync<T>(HttpClient httpClient, string ApiUrl, string JsonContent) where T : new()
        {
            try
            {
                using (httpClient)
                {
                    httpClient.BaseAddress = new Uri(ApiUrl);
                    httpClient.DefaultRequestHeaders.Accept.Clear();
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var content = new StringContent(JsonContent, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(ApiUrl, content).ConfigureAwait(false).GetAwaiter().GetResult();
                    var responseContent = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(responseContent);
                    }
                  
                    return responseContent.JsonToObject<T>();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<T> PostAsync<T>(string ApiUrl, string JsonContent) where T : new()
        {
            return await PostAsync<T>(ClientHelper.GetClient(), ApiUrl, JsonContent);
        }

        public static async Task<T> PostByTokenAsync<T>(string ApiUrl, string JsonContent,string Token) where T : new()
        {
            return await PostAsync<T>(ClientHelper.GetClient(Token), ApiUrl, JsonContent);
        }

        public static async Task<T> PostByTokenAsync<T>(string ApiUrl, string JsonContent) where T : new()
        {
            return await PostAsync<T>(ClientHelper.GetClient(_Token), ApiUrl, JsonContent);
        }

        public static async Task<T> PostByBasicAuthAsync<T>(string ApiUrl, string JsonContent,string Username,string Password) where T : new()
        {
            return await PostAsync<T>(ClientHelper.GetClient(Username, Password), ApiUrl, JsonContent);
        }

        #endregion


        public static string GetToken(string ApiUrl,string Username,string Password)
        {
            try
            {
                if (!string.IsNullOrEmpty(_Token)) return _Token;
                using (var client = new HttpClient())
                {
                    //setup client
                    client.BaseAddress = new Uri(ApiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    //setup login data
                    var formContent = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("grant_type", "password"),
                        new KeyValuePair<string, string>("username", Username),
                        new KeyValuePair<string, string>("password", Password),
                    });

                    //send request
                    var responseMessage = client.PostAsync("token", formContent).Result;
                    //get access token from response body
                    var responseJson = responseMessage.Content.ReadAsStringAsync().Result;
                    var jObject = JObject.Parse(responseJson);
                    if (responseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        _Token = jObject.GetValue("access_token").ToString();
                        return _Token;
                    }
                    else
                    {
                        throw new Exception("Get Token failed!" + "\n" + responseJson);
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public static class ClientHelper
    {
        // Basic auth
        public static HttpClient GetClient(string username, string password)
        {
            var authValue = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{username}:{password}")));
            return new HttpClient
            {
                DefaultRequestHeaders = { Authorization = authValue }
            };
        }

        // Auth with bearer token
        public static HttpClient GetClient(string token)
        {
            var authValue = new AuthenticationHeaderValue("Bearer", token);
            return new HttpClient
            {
                DefaultRequestHeaders = { Authorization = authValue }
            };

        }

        public static HttpClient GetClient()
        {
            return new HttpClient();
        }
    }
}