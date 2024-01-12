/*Console.Write("Enter File Name: ");
string FileName = Console.ReadLine();
Console.WriteLine("Searching...");

List<string> Finded = new List<string>();
DriveInfo[] Disklar = DriveInfo.GetDrives();
for (int i = 0; i < Disklar.Length; i++)
{
    Qidiruv(Finded, Convert.ToString(Disklar[i]), FileName);
}

Console.WriteLine("A few moments later: ");
foreach (string f in Finded)
    Console.WriteLine(f);

void Qidiruv(List<string> FindedDate, string Path, string FileName)
{
    string[] Files = Directory.GetFiles(Path);
    foreach (string f in Files)
    {
        string[] filenomi = f.Split('\\');
        if (filenomi[filenomi.Length - 1] == FileName)
            FindedDate.Add(f);
    }


    string[] folders = Directory.GetDirectories(Path);
    foreach (string f in folders)
    {

        try
        {
            Qidiruv(FindedDate, f, FileName);
        }
        catch { }
    }

}*/