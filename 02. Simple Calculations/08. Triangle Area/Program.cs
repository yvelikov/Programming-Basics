﻿using System;
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
            var a= double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = a*h/2;
            
            Console.WriteLine(Math.Round(area, 2));
                  }
    }
}