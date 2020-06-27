using System;
using System.Text;

namespace AB_sub5_10952
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s;
            while (true)
            {
                s = Console.ReadLine().Split();
                if (int.Parse(s[0]) == 0 && int.Parse(s[1]) == 0)
                    break;
                Console.WriteLine(int.Parse(s[0]) + int.Parse(s[1]));
                
            }


        }
    }
}
