
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace HomeWork1
{
    class Program
    {

        static void Main(string[] args)
        {
            

            int a = 15;
            int b = 35;
            string s = "Your salary is: ";

            User u = new User();
            u.FName = "Evgeniy";
            u.LName = "Makeev";
            u.Email = "Makeev@gmail.com";
            Console.WriteLine(s + a + b);
           // Console.ReadKey();
        }
    }

}
