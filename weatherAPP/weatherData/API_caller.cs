using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace weatherAPP
{
    public class API_caller
    {
        public static HttpClient Client { get; set; }
        static string API_key = "8d485977ec335bf8e79029601c107efe"; // api key from sever 
        static string News_key = "30cc1347138649189a4683989784dbe5"; // api key from news sever 

        public static void initClient()
        {

            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add
                (new MediaTypeWithQualityHeaderValue("application/json")); // request for json 
        }

        public static async Task<current_data.RootObject> requestCurrent(
            double lat = 10, double lon = 106)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather";
            url += $"?lat={lat}&lon={lon}";
            url += $"&appid={API_key}";

            Console.WriteLine("current weather url:");
            Console.WriteLine(url + '\n');

            try
            {
                using (HttpResponseMessage respond = await Client.GetAsync(url))
                {
                    current_data.RootObject data = await respond.Content.ReadAsAsync
                        <current_data.RootObject>();
                    return data;
                }
            }
			catch
			{
				throw new Exception(); 
			}
        }

        public static async Task<weekly_data.RootObject> requestWeeklyData(
            double lat = 10, double lon = 106)
        {
            string url = "http://api.openweathermap.org/data/2.5/forecast";
            url += $"?lat={lat}&lon={lon}";
            url += $"&appid={API_key}";

            Console.WriteLine("weekly data url:");
            Console.WriteLine(url + '\n');

            try
            {
                using (HttpResponseMessage respond = await Client.GetAsync(url))
                {
                    weekly_data.RootObject data = await respond.Content.ReadAsAsync
                        <weekly_data.RootObject>();
                    return data;
                }
            }
			catch
			{
				throw new Exception(); 
			}
        }
    }
}
