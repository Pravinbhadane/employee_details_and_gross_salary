using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details
{
    internal class Calculation
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Addition(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Addition(double a, double b)
        {
            return a + b;
        }

        //SUBTRACTION
            public int Subtraction(int a, int b)
            {
                return a - b;
            }
            public int Subtraction(int a, int b, int c)
            {
                return a - b + c;
            }
            public double Subtraction(double a, double b)
            {
                return a - b;
            }

        //MULTIPLY
                    public int Multiplication(int a, int b)
                    {
                        return a * b;
                    }
                    public int Multiplication(int a, int b, int c)
                    {
                        return a * b * c;
                    }
                    public double Multiplication(double a, double b)
                    {
                        return a * b ;
                    }

    }
}
