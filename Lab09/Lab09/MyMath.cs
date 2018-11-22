using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {

        private double result;
        public double operand1;
        public double operand2;

        public void Multiply(double operand1, double operand2)
        {
            result = operand1 * operand2;
        }

       public void Divide(double operand1, double operand2)
        {
            result = operand1 / operand2;
        }

       public void Subtract(double operand1, double operand2)
        {
            result = operand1 - operand2;
        }
        public void Add(double operand1, double operand2)
        {
            result = operand1 + operand2;
        }

         public double GetResult()
        {
            return result;
        }


    }
}
