class Program
{
    static void Main(string[] args)
    {
        // File nomini o'qib olish
        Console.WriteLine("File nomini kiriting:");
        string fileName = Console.ReadLine();

        // Barcha disk va papkalarni o'z ichiga oladigan array
        string[] drives = Directory.GetLogicalDrives();

        // Har bir disk va papkani tekshirish
        foreach (string drive in drives)
        {
            try
            {
                // File nomiga mos keladigan barcha file larni topish
                string[] files = Directory.GetFiles(drive, fileName, SearchOption.AllDirectories);

                // Topilgan file larni path bilan birga chiqarish
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (Exception e)
            {
                // Foydalanuvchi huquqi berilmagan bo'lsa, xatolikni chiqarish
                Console.WriteLine(e.Message);
            }
        }
    }
}