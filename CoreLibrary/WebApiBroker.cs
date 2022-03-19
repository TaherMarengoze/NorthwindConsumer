using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CoreLibrary.Models;

namespace CoreLibrary
{
    public static class WebApiBroker
    {
        static HttpClient client = new HttpClient();

        public static void Init()
        {
            client.BaseAddress = new Uri("http://localhost:63660/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<List<Category>> GetCategoriesAsync(string path)
        {
            List<Category> categories = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                categories = await response.Content.ReadAsAsync<List<Category>>();
            }
            return categories;
        }
    }
}
