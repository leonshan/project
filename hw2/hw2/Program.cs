using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 10, 20, 30, 40, 50 };
            int max = 0;
            for (int i = 0; i < values.Length; i++)
            {
                int temp = values[i];
                if (values[i] > max)
                    max = values[i];

            }
            Console.WriteLine(max);
            {
                Console.ReadKey();
            }
        }
    }
}
