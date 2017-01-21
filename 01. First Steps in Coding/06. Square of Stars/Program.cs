using System;
					
public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*',n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string(' ', n - 2));
                Console.WriteLine('*');
            }
            Console.WriteLine(new string('*', n));
	}
}