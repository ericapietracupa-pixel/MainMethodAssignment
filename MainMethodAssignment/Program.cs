using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MethodOverloading class
            MethodOverloading mo = new MethodOverloading();

            int num1 = 15;
            // Call the firth method passing in an int parameter
            Console.WriteLine(mo.MathOp(num1));

            decimal num2 = 50.5m;
            // Call the second method passing in a decimal parameter
            Console.WriteLine(mo.MathOp(num2));

            string num3 = "50";
            // Call the third method passing in a string parameter
            Console.WriteLine(mo.MathOp(num3));

            // Readline to pause program before quitting
            Console.ReadLine();
        }
    }
}
