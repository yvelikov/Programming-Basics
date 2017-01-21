using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var format = "dd-MM-yyyy";
            DateTime date = DateTime.ParseExact(Console.ReadLine(), format, null);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
