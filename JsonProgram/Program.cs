using JsonProgram.MyModels;
using JsonProgram.MyModelsThree;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Immutable;
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

//using System.Text.Json.Serialization;
//using System.Text.Json;


/*MyModel myModel = new MyModel();
myModel.ID = 1;
myModel.Name = "Abdullayev Dilshodbek"; 
myModel.Username = "admin";
myModel.Email = "emailDilshdbek.com";
myModel.Address = new Address()
{
    Street = "Besh ariq",
    Suite = "APT.556",
    City = "Yangiyo'l",
    ZipCode = "100056",
    Geo = new Geo()
    {
        Lat = "-37.5264",
        Lang = "81.642342",
        Magic = new Magic()
        {
            Type = "11",
            Section = "my section"
        }
    }
};
myModel.Phone = "+998908136252";
myModel.WebSite = "Najot ta'lim";
myModel.Company = new Company()
{
    Name = "Najot ta'lim",
    CatchPhrase = "multi - layered",
    BS = "harness"
};
myModel.Location = new Location()
{
    Address = "second adress",
    Mintaqa = new Mintaqa()
    {
        Hudud = "Uzbekistan",
        Manzil = "Toshkent",
        Mahalla = new Mahalla()
        {
            Name = "Yangiyol",
            Kucha = "Besh buloq"
        }
    }
};
string path = @"D:\Zip\Najot Ta'lim\C#\C#\JsonProgram\testJson.json";
string json = JsonSerializer.Serialize(myModel);
File.WriteAllText(path,json);
*/
/*
MyModel2 myModel2 = new MyModel2()
{
    ID = 1,
    FName = "Name 1",
    LName = "Surname 1",
    Age = 25
};

MyModel2 myModel3 = new MyModel2()
{
    ID = 2,
    FName = "Name 2",
    LName = "surname 2",
    Age = 24
};
MyModel2 myModel1 = new MyModel2()
{
    ID = 3,
    FName = "Name 3",
    LName = "surname 3",
    Age = 20
};
List<MyModel2> list = new List<MyModel2>();

list.Add(myModel2);
list.Add(myModel3);
list.Add(myModel1);
string path = @"D:\Zip\Najot Ta'lim\C#\C#\JsonProgram\testJson.json";
string json2 = JsonSerializer.Serialize(list);
File.WriteAllText(path, json2);
*/


internal class Program
{
    public static void Main(string[] args)
    {
        var path = "D:\\Zip\\Najot Ta'lim\\C#\\C#\\JsonProgram\\datajson.txt";
        var jsonRes = JObject.Parse(path);

  

        /* List<MyModels> list = new List<MyModels>();
         list = JsonConvert.DeserializeObject<List<MyModels>>(json)*/
        /* foreach (var root in list)
        {
            Console.WriteLine(root.userId);
            Console.WriteLine(root.id);
            Console.WriteLine(root.title);
            Console.WriteLine(root.body);

        }*/



    }
}