
using Newtonsoft.Json.Linq;
using System.Diagnostics;

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://tester.consimple.pro/");


response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();


Console.WriteLine($"Отправить гет запрос ведите (1)" +
    $"Выйти нажмите (2)");

string answer = Console.ReadLine();

    if (answer == "1")
    {
    Console.WriteLine(JToken.Parse(responseBody).ToString());
        
    }
    if (answer == "2")
    {
    Process.GetCurrentProcess().Kill();
    }





