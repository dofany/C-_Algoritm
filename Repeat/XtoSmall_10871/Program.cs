using System;
using System.Text;

namespace XtoSmall_10871
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder st = new StringBuilder();
            string[] n = Console.ReadLine().Split();
            int x = int.Parse(n[1]);
            string[] a = Console.ReadLine().Split();
            foreach(var input in a) 
            {
                if(x>int.Parse(input))
                {
                    st.Append(input + " ");
                }
            }
            Console.Write(st);
        }
    }
}
