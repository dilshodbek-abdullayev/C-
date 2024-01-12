using Project_HTTP.HTTP_Methods.TestClass;

using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Project_HTTP.HTTP_Methods
{
    public class Class1
    {
     
        
        public static async Task GetAsync(HttpClient httpClient)
        {
            using HttpResponseMessage response = await httpClient.GetAsync("todos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

           var jsonResponse = await response.Content.ReadAsStringAsync();

             Console.WriteLine($"{jsonResponse}\n");
        }
        public static async ValueTask<List<Todo>> GetFromJsontoList(HttpClient httpClient)
        {
            var todos = await httpClient.GetFromJsonAsync<List<Todo>>(
                "todos?userId=1&completed=false");
           
            return todos;
        
        }

        public static async ValueTask<string> PostAsync(HttpClient httpClient)
        {
            using StringContent jsonContent = new
            (
               JsonSerializer.Serialize(new
               {
                   userId = 77,
                   id = 1,
                   title = "Title",
                   complete = false
               }),
               Encoding.UTF8, "application/json"
             );
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("todos", new Todo(UserId:9,Id:99,Title:"title",Complete:false));

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }

        public static async ValueTask<string> PutAsync(HttpClient httpClient)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    userId = 1233,
                    id = 1,
                    title = "update code sample",
                    complete = true
                }
                ), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PutAsync("todos/1", jsonContent);

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;

        }

        public static async ValueTask<string> PatchAsync(HttpClient httpClient)
        {
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(new
                {
                    title = "patch orqali code sample",
                }
                ),
                Encoding.UTF8, "application/json"
                );
            HttpResponseMessage response = await httpClient.PatchAsync("todos/1", jsonContent);
            response.EnsureSuccessStatusCode().WriteRequestToConsole();
            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }

        public static async ValueTask<string> DeleteAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync("todos/1");

            response.EnsureSuccessStatusCode().WriteRequestToConsole();

            string jsonResult = await response.Content.ReadAsStringAsync();

            return jsonResult;
        }
    }
  
}
