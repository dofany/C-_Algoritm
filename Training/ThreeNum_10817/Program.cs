using System;

namespace ThreeNum_10817
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
			int a = int.Parse(num[0]);
			int b = int.Parse(num[1]);
			int c = int.Parse(num[2]);
			if (a < b)
			{
				if (b < c)
				{
					Console.WriteLine(b);
				}
				else if (a < c)
				{
					Console.WriteLine(c);
				}
				else
				{
					Console.WriteLine(a);
				}
			}
			else
			{
				if (a < c)
				{
					Console.WriteLine(a);
				}
				else if (c < b)
				{
					Console.WriteLine(b);
				}
				else
				{
					Console.WriteLine(c);
				}
			}


		}
    }
}
