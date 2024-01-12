using Project_HTTP.Bank;
using Project_HTTP.HTTP_Methods;

/*Banks banks = new Banks();
banks.Met();*/
public class Programm { 
private static HttpClient sharedClient = new()
{
    BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
};
static async Task Main(string[] args)
{
    Class1.GetAsync(sharedClient).Wait();
        string result2 = await Class1.DeleteAsync(sharedClient);
        string result3 = await Class1.PatchAsync(sharedClient);
        string result4 = await Class1.PutAsync(sharedClient);

        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
    }
}