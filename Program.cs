using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public delegate int Operation(int x, int y);

    class Program
    {
        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static int Sub(int x, int y)
        {
            return x - y;
        }

        private static int Mult(int x, int y)
        {
            return x * y;
        }

        private static int Div(int x, int y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            Operation op = Div;
            Operation op1 = Add;
            Operation op2 = Sub;
            Operation op3 = Mult;
            op += (x, y) => { return x / y; };
            op += (x, y) => { return x * y; };
            op += (x, y) => { return x - y; };
            op += (x, y) => { return x + y; };

            
                    op = (x, y) =>
                    {
                        if (y != 0)
                        {
                            return x / y;
                        }
                        else
                        {
                            Console.WriteLine("На нуль дилити не можна!");
                            return 0;
                        }
                    };


            Console.WriteLine(op(35, 7));
            Console.ReadKey();
        }
    }
}
