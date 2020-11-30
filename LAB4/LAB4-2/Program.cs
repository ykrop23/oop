using System;

namespace LAB4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            B1 b1 = new B1();
            b1.GetLvl(12, 2);

        }
    }
}
