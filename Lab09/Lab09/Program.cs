using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath iMyMath = new MyMath();


           
            iMyMath.Multiply(10, 20);
            Console.WriteLine("The result for multiplication is: " + iMyMath.GetResult());

            iMyMath.Divide(30, 20);
            Console.WriteLine("The result of division is:" + iMyMath.GetResult());

            iMyMath.Subtract(20, 10);
            Console.WriteLine("The result of subtraction is:" + iMyMath.GetResult());

            iMyMath.Add(100, 200);
            Console.WriteLine("The result of addition is:" + iMyMath.GetResult());
                 
        }


    }
}
