using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "a", "b", "1", "2" };
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
            //Array.Reverse(array);

            string[] reversed = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversed[array.Length - i - 1] = array[i];
            }
            array = reversed;

            Console.WriteLine("Reversed Array:");
            foreach (string value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();


        }
    }
}

