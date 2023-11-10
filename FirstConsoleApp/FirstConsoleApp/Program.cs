using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, passwordTemp;
            int password;

            Console.WriteLine("Welcome to the login system ");

            for (int attemp = 2; attemp > -1; attemp--)
            {
                Console.Write("username : ");
                username = Console.ReadLine();

                Console.Write("password : ");
                passwordTemp = Console.ReadLine();
                Int32.TryParse(passwordTemp, out password);

                if (username == "admin" && password == 0000)
                {
                    Console.WriteLine("Hello admin! \n" +
                        "1 - User List\n" +
                        "2 - Logout");
                    passwordTemp = Console.ReadLine();
                    int i;
                    Int32.TryParse(passwordTemp, out i);
                    if (i == 1)
                    {
                        Console.WriteLine("Admin");
                        Console.WriteLine("And");
                        Console.WriteLine("Your");
                        Console.WriteLine("MOM");

                    }
                    attemp = -2;

                }
                else
                {
                    Console.WriteLine("Wrong username and password! LEfty attemp : " + attemp);
                }
            }
            

        }
    }
}
