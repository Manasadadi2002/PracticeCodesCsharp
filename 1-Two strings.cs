﻿using System;
using System.Linq;

namespace Practise_tasks
{
    class Program
    {
      public   static void Main(string[] args)
        {
            Console.WriteLine("enter the two strings");
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string reversedname1 = new string(name1.Reverse().ToArray());
            if (reversedname1 == name2)
            {
                Console.WriteLine("equal strings");
            }
            else
                Console.WriteLine("not equal");
        }
    }
}
