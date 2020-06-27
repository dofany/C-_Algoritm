using System;

namespace AlarmClock_2884
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


                b -= 45;
            if (b < 0)
            {
                if (a != 0)
                {
                    a -= 1;
                    b += 60;
                }
                else
                {
                    a = 23;
                    b += 60;
                }
            }

            Console.Write(a);
            Console.Write(b);


        }
    }
}
