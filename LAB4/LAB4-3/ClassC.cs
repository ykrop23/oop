using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_3
{
    class ClassC : ClassA
    {
        private int __char = '-';
        public int Char2 { get; private set; }
        public int Char3 { private get; set; }
        public ClassC(char c, char c1, string p1, string p2) : base(p1, p2)
        {
            Char2 = c;
            Char3 = c1;
        }
        public void Calc(int n)
        {
            Console.WriteLine(__char + Char2 + Char3);
        }
    }
}
