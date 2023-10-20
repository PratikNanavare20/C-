using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{ 
    public abstract class Area
    {
        public abstract void rect();
        public abstract void squa();
        public abstract void circle();
        public abstract void triangle();
    }
    public class Operation : Area 
    {
        public override void rect()
        {
            int l = 10;
            int b = 20;

            Console.WriteLine("The area of rectangle is  = "+(l*b));
        }

        public override void squa()
        {
            int side = 5;
            Console.WriteLine("The area of square is  = " + (side * side));
        }

        public override void circle()
        {
            int radious = 7;
            Console.WriteLine("The area of circle is  = " + (3.14 * radious * radious));
        }

        public override void triangle()
        {
            int l = 10;
            int b = 40;
            Console.WriteLine("The area of triangle is  = " + (0.5 * l * b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation o = new Operation();
            o.rect();
            o.squa();
            o.circle();
            o.triangle();
        }
    }
}
