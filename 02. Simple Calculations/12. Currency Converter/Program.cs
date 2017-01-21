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
            var sum = double.Parse(Console.ReadLine());
            var currencyIN = Console.ReadLine().ToLower();
            var currencyOUT = Console.ReadLine().ToLower();

            if (currencyIN == "bgn")
            {

                if (currencyOUT == "usd")
                {
                    Console.Write("{0:F2}", sum *1/ 1.79549);
                    Console.WriteLine(" USD");
                }
                if (currencyOUT == "eur")
                {
                    Console.Write("{0:F2}", sum *1/ 1.95583);
                    Console.WriteLine(" EUR");
                }
                if (currencyOUT == "gbp")
                {
                    Console.Write("{0:F2}", sum*1 / 2.53405);
                    Console.WriteLine(" GBP");
                }
                

            }


            if (currencyIN == "usd")
            {

                if (currencyOUT == "bgn")
                {
                    Console.Write("{0:F2}", sum * 1.79549/1);
                    Console.WriteLine(" BGN");
                }
                if (currencyOUT == "eur")
                {
                    Console.Write("{0:F2}", sum * 1.79549/1.95583);
                    Console.WriteLine(" EUR");
                }
                if (currencyOUT == "gbp")
                {
                    Console.Write("{0:F2}", sum *  1.79549/ 2.53405);
                    Console.WriteLine(" GBP");
                }
                
            }
            if (currencyIN == "eur")
            {

                if (currencyOUT == "usd")
                {
                    Console.Write("{0:F2}", sum * 1.95583/ 1.79549);
                    Console.WriteLine(" USD");
                }
                if (currencyOUT == "bgn")
                {
                    Console.Write("{0:F2}", sum * 1.95583/1);
                    Console.WriteLine(" BGN");
                }
                if (currencyOUT == "gbp")
                {
                    Console.Write("{0:F2}", sum * 1.95583/2.53405);
                    Console.WriteLine(" GBP");
                }
                
            }
            if (currencyIN == "gbp")
            {

                if (currencyOUT == "usd")
                {
                    Console.Write("{0:F2}", sum * 2.53405/1.79549);
                    Console.WriteLine(" USD");
                }
                if (currencyOUT == "eur")
                {
                    Console.Write("{0:F2}", sum * 2.53405/ 1.95583);
                    Console.WriteLine(" EUR");
                }
                if (currencyOUT == "bgn")
                {
                    Console.Write("{0:F2}", sum * 2.53405/1);
                    Console.WriteLine(" BGN");
                }
                

            }
        }
    }
}
