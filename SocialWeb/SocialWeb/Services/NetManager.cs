using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace SocialWeb.Services
{
    public static class NetManager
    {
        public static string URL = "http://localhost:56945/api/";
        static HttpClient httpClient = new HttpClient();


        public static async Task<T> Get<T>(string controller)
        {
            var response = await httpClient.GetAsync(URL + controller);
            var content = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<T>(content);
            return data;
        }

        //public static async void Post<T>(string controller, T data)
        //{
        //    var json = JsonConvert.SerializeObject(data);
        //    var response = await httpClient.PostAsync(URL + controller, new StringContent(json, Encoding.UTF8, "application/json"));
        //    //var responseString = await response.Content.ReadAsStringAsync();
        //    //var result = JsonConvert.DeserializeObject<T>(responseString);
        //    //return result;
        //}

        public static async Task<T> Post<T>(string controller, T data)
        {
            var json = JsonConvert.SerializeObject(data);
            var response = await httpClient.PostAsync(URL + controller, new StringContent(json, Encoding.UTF8, "application/json"));
            var responseString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<T>(responseString);
            return result;
        }

        public static async Task<HttpResponseMessage> Put<T>(string controller, T data) // для редактирования
        {
            var json = JsonConvert.SerializeObject(data);
            var response = await httpClient.PutAsync(URL + controller, new StringContent(json, Encoding.UTF8, "application/json"));
            return response;
        }

        public static async Task<HttpResponseMessage> Delete<T>(string controller)
        {
            var response = await httpClient.DeleteAsync(URL + controller);
            return response;
        }
    }

}
