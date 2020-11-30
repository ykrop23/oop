using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_3
{
    class ClassA
    {
        public string pole1 { get; private set;}
        public string pole2 { get; set; }
        public ClassA(string p1, string p2)
        {
            pole1 = p1;
            pole2 = p2;
        }
    }
}
