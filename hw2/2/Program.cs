using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < values.Length; i++)
            {
                sum = sum + values[i];

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
