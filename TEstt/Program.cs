
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TEstt;
//return get
async Task<string> JSonAsync()
{

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://tester.consimple.pro/");

response.EnsureSuccessStatusCode();
return await response.Content.ReadAsStringAsync();
}

void ShowModel(Json Json)
{
    Console.WriteLine("Products");
    foreach (var item in Json.Products)
    {
        Console.WriteLine("------------------");
        Console.WriteLine($"Id:{item.Id}");
        Console.WriteLine($"Name:{item.Name}");
        Console.WriteLine($"CategoryId:{item.CategoryId}");
        Console.WriteLine("----------------------");
    };
    Console.WriteLine("Categories");
    foreach (var item in Json.Categories)
    {
        Console.WriteLine("----------------------");
        Console.WriteLine($"Name:{item.Name}");
        Console.WriteLine($"Id:{item.Id}");
        Console.WriteLine("-------------------");
    }
}


string responseBody = JSonAsync().Result;
//Console.WriteLine(responseBody);
Json account = JsonConvert.DeserializeObject<Json>(responseBody);

string json = JsonConvert.SerializeObject(account, Formatting.Indented);


while (true)
{
    Console.WriteLine("1=Десерилизовать ,2= Серелизировать,3=сотановить");
    string answer = Console.ReadLine();

    if (answer == "1")
    {
        ShowModel(account);


    }
    else if (answer == "2")
    {
        Console.WriteLine(json);
    }
    else if(answer=="3")
    {
        Environment.Exit(0);

    }
}







