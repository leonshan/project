using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 0,10, -20, 30, -40, 50 };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= 0)
                {
                    values[i]++;
                }
                else
                {
                    values[i]--;

                }

                Console.WriteLine(values[i]);
            }

        }
    }
}
