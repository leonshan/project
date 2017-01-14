using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = {10, -20, 30, -40, 50 };
            //string[] strArr = new string[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                //strArr[i] = values[i].ToString();

                Console.WriteLine("\""+values[i]+"\"");
            }
        }
    }
}