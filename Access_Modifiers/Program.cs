using System;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user  = new User();
            user.Username = "";
            Console.WriteLine(user.Username);
            user.Password = "";
            Console.WriteLine(user.Password);
            Admin admin = new Admin("1","Islam5","Islamm");
            Console.WriteLine(admin);
            
        }
    }
}
