using Newtonsoft.Json;

namespace JsonProgram.MyModelsThree
{
    public class MyModels
    {
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }
        
    }
}
    

