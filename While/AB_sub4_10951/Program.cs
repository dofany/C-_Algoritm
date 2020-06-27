using System;

namespace AB_sub4_10951
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string a = Console.ReadLine();
                if (a == null)
                    break;
                string[] s = a.Split(' ');
                int x = int.Parse(s[0]);
                int y = int.Parse(s[1]);
                Console.WriteLine(x + y);

            }

        }
    }
}
