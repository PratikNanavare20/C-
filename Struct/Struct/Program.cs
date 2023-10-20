using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    public struct color
    {
        public string name;
    }

    //Struct keyword using constructor and field or method
    public struct rect
    {
        public int l;
        public int b;

        public rect(int l, int b)
        {
            this.l = l;
            this.b = b;
        }

        public void area()
        {
            Console.WriteLine(l*b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            color c = new color();
            c.name = "Red";
            c.name = "Black";

            Console.WriteLine(c.name);

            //Struct keyword using constructor and field or method
            rect r = new rect(2,3);
            r.area();
        }
    }
}
