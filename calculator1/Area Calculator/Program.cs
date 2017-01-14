using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //MVC
            //Model, View, Controller
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());


            cal1 calculator = new cal1();
            //Console.WriteLine(calculator.Add(firstNum, secondNum));
            double answer = calculator.Add(10, 15);
            calculator.Add(10.5, 15.5);
            calculator.Add(10, 15, 25);

            double answer1 = calculator.Subract(10, 15);
            calculator.Subract(10.5, 15.5);
            calculator.Subract(10, 15, 25);

            double answer2 = calculator.multiple(10, 15);
            calculator.multiple(10.5, 15.5);
            calculator.multiple(10, 15, 25);

            double answer3 = calculator.devide(10, 15);
            calculator.devide(10.5, 15.5);
            calculator.devide(10, 15, 25);

            Console.WriteLine(answer);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);

        }

    }
}
