using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_HTTP.Bank;
using System.Text.Json;

namespace Project_HTTP.Bank
{
    public class Banks
    {
        public void Met() { 
            try
            {

                Console.WriteLine("Valyuta ayirboshlashni kiriting => ");
                string kurs1 = Console.ReadLine();
                string kurs2 = Console.ReadLine();

                Console.WriteLine($"{kurs1} summani kiriting => ");
                float summa = float.Parse(Console.ReadLine());

                HttpClient client = new HttpClient();
                string path = "https://nbu.uz/exchange-rates/json/";

                var request = new HttpRequestMessage(HttpMethod.Get, path);

                var response = client.SendAsync(request).Result;

                var body = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(body);
                var courses = JsonSerializer.Deserialize<List<Kurslar>>(body);
                foreach ( var kurslar in courses)
                {
                    Console.WriteLine(kurslar.CbPrice);
                }
                float res = 1F;
                float summ1 = 0F;
                float summ2 = 0F;
                foreach (var i in courses)
                {
                    if (kurs1.ToUpper() == i.Code)
                    {
                        summ1 = i.CbPrice;
                    }
                    else if (kurs2.ToUpper() == i.Code)
                    {
                        summ2 = i.CbPrice;
                    }
                }
                Console.WriteLine(summ1);
                Console.WriteLine(summ2);

                if (kurs1.ToUpper() == "UZS")
                {
                    res = summ1/summ2; 
                }
                else if(kurs2.ToUpper() == "UZS")
                {
                    res = summ1 * summ2;
                }
                
                Console.WriteLine($"{kurs1} convert to {kurs2} => {0}",res);
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }      
    }
}
