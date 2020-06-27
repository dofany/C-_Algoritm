using System;

namespace AB_sub3_10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i<t; i++)
            {
                string[] a = Console.ReadLine().Split(' ');
                Console.WriteLine(int.Parse(a[0]) + int.Parse(a[1]));
            }
        }
    }
}
