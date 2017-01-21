using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var tempC= double.Parse(Console.ReadLine());
            var tempF = tempC *1.8 + 32;
            
            Console.WriteLine(Math.Round(tempF, 2));
                  }
    }
}