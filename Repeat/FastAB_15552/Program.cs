using System;
using System.IO;
using System.Linq;

namespace FastAB_15552
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var inStream = new BufferedStream(Console.OpenStandardInput()))
            using (var outStream = new BufferedStream(Console.OpenStandardOutput()))
            using (var reader = new StreamReader(inStream))
            using(var writer = new StreamWriter(outStream))
            {
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i<n; i++)
                {
                    var sum = reader.ReadLine().Split().Select(int.Parse).Sum();
                    writer.WriteLine(sum);
                }
            }
        }
    }
}
