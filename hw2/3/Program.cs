using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        private static string hello;

        static void Main(string[] args)
        {
            string[] arr = new string[] { "hello", "ware", "aca" };
            arr[0] = "hello";
            arr[1] = "ware";
            arr[2] = "aca";

            Console.WriteLine(arr[0] + "-" + arr[1] + "-" + arr[2]);
            Console.ReadKey();

        }
    }
}
