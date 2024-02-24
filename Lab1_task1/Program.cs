using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kirkovskaya lab1 task1";
            Address myAddress = new Address("5685", "Urkaine", "Kyiv", "Svetlytskyi street", "30A", "56");
            myAddress.DisplayAddress();
        }
    }
}
