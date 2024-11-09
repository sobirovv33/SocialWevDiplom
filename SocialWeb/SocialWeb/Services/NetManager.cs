using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SocialWeb.Services
{
    public static class NetManager
    {
        private static HttpClient _httpClient = new HttpClient();
        private static string _url = "http://localhost:56945/api/";

        public static async Task<T> Get<T>(string url)
        {
            var response = await _httpClient.GetAsync("http://localhost:56945/api/Users/GetUsers");
            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);  
        }

        // Метод для отправки данных на сервер через POST
        // не пон
        public static async Task<T> Post<T, U>(string endpoint, U data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(_url + endpoint, content);
            response.EnsureSuccessStatusCode();

            var resultJson = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(resultJson);
        }
    }
}
