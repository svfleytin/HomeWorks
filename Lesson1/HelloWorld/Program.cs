using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, how can I call you?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Today is {DateTime.Now}.");
            Console.WriteLine($"Hello, {name}! Today is {DateTime.Now}.");
        }
    }
}
