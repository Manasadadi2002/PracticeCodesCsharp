﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_tasks
{
    class AverageOfTenNumbers
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter any number:");
            for (int i = 0; i < 10; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of the numbers is :{a.Sum()}");
            Console.WriteLine($"Average of numbers:{a.Sum() / a.Length}");
        }
    }
}
