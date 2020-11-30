using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_2
{
    class B2 : B
    {
        public int years = 0;
        public override void GetLvl(int n1, int n2 = 2, int n3 = 3)
        {
            __lvl += years;
        }
    }
}
