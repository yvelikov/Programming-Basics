using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var number = int.Parse(Console.ReadLine());
            Console.Write("Square = ");
            Console.WriteLine(number*number);
        }
    }
}
