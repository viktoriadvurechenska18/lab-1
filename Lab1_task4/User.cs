using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_task4
{
    internal class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            if (age <= 0)
            {
                throw new ArgumentException("Age should be a positive integer.");
            }
            this.age = age;
            this.registrationDate = DateTime.Now;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("User Information:");
            Console.WriteLine($"Login: {login}");
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Registration Date: {registrationDate}");
        }
    }
}
