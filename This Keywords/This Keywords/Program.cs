using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Keywords
{
    public class Example
    {
        int a;
        int b;
        public void add(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("The addition of a and b is = "+(a+b));
        }

        public void sub(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("The substracation of a and b is = " + (a - b));
        }

        public void mul(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("The multiplication of a and b is = " + (a * b));
        }

        public void div(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("The Division of a and b is = " + (a / b));
        }

        public void mod(int a, int b)
        {
            this.a = a;
            this.b = b;

            Console.WriteLine("The Module of a and b is = " + (a % b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            e.add(1, 2);
            e.sub(2, 4);
            e.mul(2, 3);
            e.div(10,5);
            e.mod(6,3);
            e.mod(7, 3);
        }
    }
}
