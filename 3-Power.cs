using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_tasks
{
    class Power
    {
        static void Main(string[] args)
        {
            int result = 1;
            Console.WriteLine("Enter any number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power");
            int pow = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < pow; i++)
            {
                result *= n;

            }
            Console.WriteLine(result);
        }
    }
}
