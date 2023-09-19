using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i1 = 123;
            float f1 = 12.76f;
            decimal d1 = 34.6m;
            double d2 = 100372.3047d;
            Boolean b1 = true;

            Console.WriteLine(i1);
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(b1);

            Console.WriteLine("The type of the variables");
            Console.WriteLine(i1.GetType());
            Console.WriteLine(f1.GetType());
            Console.WriteLine(d1.GetType());
            Console.WriteLine(d2.GetType());
            Console.WriteLine(b1.GetType());
        }
    }
}
