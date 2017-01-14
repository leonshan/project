using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class shapeareacal
    {
        private double _width;
        private double _height;
        private double _radius;
        internal int radius;

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        internal double GetcircleShapeArea()
        {
            return 3.14 * _radius * _radius;
        }

        public double Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
            }
        }


        public shapeareacal(double width, double height)
        {
            _width = width;
            _height = height;

        }
        public shapeareacal(double radius)
        {
            _radius = radius;
        }

        public double GetrectangleArea()
        {
            return _height*_width;

        }
        public double GetcirlceArea()
        {
            return 3.14 * _radius * _radius;
}

    }
}
