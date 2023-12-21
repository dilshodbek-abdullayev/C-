using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

// 4-vazifa pastda oxirida
public class Registration
{

    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string DateOfBirthday { get; set; }
    public bool PasswordIsTrue = false;
    public bool EmailIsTrue = false;
    public bool PhoneNumberIsTrue = false;
    public bool DateOfBirthdayIsTrue = false;
    public string PatternOfPassword = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";
    public string PatternOfPhoneNumber = @"^\+?\d{12}$";
    public string PatternBirthDay = @"(\d{4})-(\d{2})-(\d{2})";
    public string PatternOfEmail = @"^\S+@\S+\.\S+$";


    public Registration()
    {
    }
    public bool CheckPassword()
    {

        PasswordIsTrue = Regex.IsMatch(Password, PatternOfPassword);
        return PasswordIsTrue;
    }
    public bool CheckEmail()
    {

        EmailIsTrue = Regex.IsMatch(Email, PatternOfEmail);

        return EmailIsTrue;
    }
    public bool CheckPhone()
    {
        PhoneNumberIsTrue = Regex.IsMatch(PhoneNumber, PatternOfPhoneNumber);
        return PhoneNumberIsTrue;
    }
    public bool CheckBD()
    {
        DateOfBirthdayIsTrue = Regex.IsMatch(DateOfBirthday,PatternBirthDay); 
        return DateOfBirthdayIsTrue;
    }
    public void Menu()
    {
        
        Console.WriteLine("Nimani tekshirmoqchisiz: \n\t1.Password Check\n\t2.Check Email\n\t3.Check Phone\n\t4.Check Birth Day");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
                case 1: Console.WriteLine(CheckPassword());break;
                case 2: Console.WriteLine(CheckEmail());break;
                case 3: Console.WriteLine(CheckPhone());break;
                case 4: Console.WriteLine(CheckBD());break;
                default: Console.WriteLine("Iltimos [1-4] oraliqda son kiriting");break;
        }

    }
}
public class Ignore
{
    public Ignore()
    {
        string matn = "w3resoSur_ce.com";
        string AfterIgnoring = Regex.Replace(matn, @"[^A-z0-9_]", "");
        Console.WriteLine(AfterIgnoring);
    }
}