using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    internal class MethodOverloading
    {
        // First method takes an int parameter 
        public int MathOp (int num) 
        {
            // Add 5 to the number and return result
            return num + 5;
        }

        // Second method takes a decimal parameter
        public int MathOp(decimal num)
        {
            // Convert the decimal to an int
            int newNum = Convert.ToInt32(num);
            // Multiply the newNum by 5 and return the result
            return newNum * 5;
        }

        // Third method takes a string parameter
        public int MathOp(String numStr)
        {
            // Convert the string to an int
            int num = Convert.ToInt32(numStr);
            // Divide the converted string num by 5 and return the result
            return num / 5;
        }
    }
}
