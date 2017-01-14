using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            shapeareacal rectangle = new shapeareacal(5.5, 8.8);
          //  rectangle.Height = 99.9;
             Console.WriteLine(rectangle.GetrectangleArea());

            shapeareacal circle = new shapeareacal(10);
            circle.radius = 100;
            Console.WriteLine(circle.GetcircleShapeArea());


        }
    }
}
