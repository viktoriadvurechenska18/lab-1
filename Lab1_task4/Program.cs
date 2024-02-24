using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your login: ");
            string login = Console.ReadLine();

            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Age should be a positive integer.");
                }
            }

            User user = new User(login, firstName, lastName, age);
            user.DisplayInfo();

            Console.ReadKey();
        }
    }
    
}
