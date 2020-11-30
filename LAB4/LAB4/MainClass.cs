using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LAB4
{
    class MainClass
    {
        private double __a = 12.5;
        private double __b = 24.6;
        public double Calculation(double firstNum, double secondNum)
        {
            Debug.WriteLine(firstNum + "\t" + secondNum);

            return (firstNum + secondNum) * __a * __b;
        }

    }
}
