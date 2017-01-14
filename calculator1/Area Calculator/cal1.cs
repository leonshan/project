using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class cal1
    {
        public double Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public double Add(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum + secondNum + thirdNum;
        }

        public double Subract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        public double Subract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public double Subract(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum - secondNum - thirdNum;
        }
        public double multiple(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        public double multiple(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public double multiple(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum * secondNum * thirdNum;
        }
        public double devide(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
        public double devide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public double devide(double firstNum, double secondNum, double thirdNum)
        {
            return firstNum / secondNum / thirdNum;
        }

    }
}
