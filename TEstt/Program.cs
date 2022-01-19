
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




string responseBody = JSonAsync().Result;
//Console.WriteLine(responseBody);
Json account = JsonConvert.DeserializeObject<Json>(responseBody);



foreach (var prod in account.Products)
    prod.Category = account.Categories.FirstOrDefault(x => x.Id == prod.CategoryId);

//string json = JsonConvert.SerializeObject(account, Formatting.Indented);

void Show()
{
foreach (var item in account.Products)
{
    var json1 = new Json()
    {
        Products = new List<Product>()
        {
             new Product()
             {
                 Id=item.Id,
                 Name=item.Name,
                 CategoryId=item.CategoryId
             }

        },
        Categories=new List<Categories>()
        {
            new Categories()
            {
                Id=item.Category.Id,
                Name=item.Category.Name
            }
        }
        
    };
    string jsondes = JsonConvert.SerializeObject(json1, Formatting.Indented);
    Console.WriteLine(jsondes);
}

}
Console.WriteLine("Поазать 1 ,Закрыть 2");
string answer = Console.ReadLine();



if (answer == "1")
    Show();
else if(answer=="2")
    Environment.Exit(0);










