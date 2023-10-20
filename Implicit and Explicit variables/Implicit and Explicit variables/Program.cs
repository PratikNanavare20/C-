using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_and_Explicit_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Variables
            var a = 10;
            Console.WriteLine(a.GetType());

            var b = 20.50m;
            Console.WriteLine(b.GetType());

            var c = 204315.50d;
            Console.WriteLine(c.GetType());

            var d = true;
            Console.WriteLine(d.GetType());

            var e = new[] {1,2,3,4,5};
            Console.WriteLine(e.GetType());

            var f = new[] { "a", "b", "c", "d" };
            Console.WriteLine(f.GetType());

            //Explicit Variables
            int i1 = 10;
            Console.WriteLine(i1.GetType());

            float i2 = 53472.864f;
            Console.WriteLine(i2.GetType());

            double i3 = 7491672.864d;
            Console.WriteLine(i3.GetType());

            Boolean i4 = true;
            Console.WriteLine(i4.GetType());

            long i5 = 2749765901264383642L;
            Console.WriteLine(i5.GetType());
        }
    }
}
