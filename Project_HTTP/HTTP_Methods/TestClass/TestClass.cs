using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_HTTP.HTTP_Methods.TestClass
{
    internal static class TestClass
    {
        internal static void WriteRequestToConsole(this HttpResponseMessage response)
        {
            if(response is null)
            {
                return;
            }
            var request = response.RequestMessage;
            Console.Write($"{request?.Method}");
            Console.Write($"{request?.RequestUri}");
            Console.WriteLine($"HTTP/{request?.Version}");
        }
    }
    public record class Todo(
        int? UserId = null,
        int? Id = null,
        string? Title = null,
        bool? Complete = null
        );
}
