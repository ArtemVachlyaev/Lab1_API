using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace Console_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:5001/");

            var data = new
            {
                A = 10,
                B = 2
            };

            var response = await client.PostAsJsonAsync("api/calculator/calculate", data);
            var result = await response.Content.ReadAsStringAsync();

            Console.WriteLine($"Результат: {result}");
        }
    }
}
