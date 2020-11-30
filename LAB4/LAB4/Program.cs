using System;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            MainClass p = new ChildClass();
            Console.WriteLine(p.Calculation(1.25, 3.4));
            ChildClass r = (ChildClass)p;
            r.Name = "Oleg";
            r.WriteMethod(r.Name, 1.8);
            
        }
 

    }
}
