using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculatoreksamenslaesning
{
    public class Calculator
    {
        public double a { get; private set; }
        public double b { get; private set; }
        public double x { get; private set; }
        public double exp { get; private set;}

        public double Add(double a, double b)
        {
            double sumA = a + b;
            return sumA;
        }

        public double Subtract(double a, double b)
        {
            double sumS = a - b;
            return sumS; 
        }

        public double Multiply(double a, double b)
        {
            double sumM = a * b;
            return sumM;
        }

        public double Power(double x, double exp)
        {
            double xx = Math.Pow(x, exp);
            return xx; 
        }

    }
}
