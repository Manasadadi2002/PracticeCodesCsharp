﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_tasks
{
    class AscendingNumbers
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string s = n.ToString();
            char[] no = s.ToCharArray();
            Array.Sort(no);

            foreach (char c in no)
            {
                Console.WriteLine(c);
            }
        }
    }
}
