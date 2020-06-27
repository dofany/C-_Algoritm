using System;

namespace AddCycle_1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int cnt = 1;
            int chk = num;

            while (true)
            {
                int a = num / 10;
                int b = num % 10;
                int c = a + b;
                num = b * 10 + c % 10;

                if (num == chk)
                    break;
                else
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
