﻿using System;

namespace MultiTable_2739
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
        
            for(int i =1; i<=9; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",n,i,n*i);
           }
        }
    }
}
