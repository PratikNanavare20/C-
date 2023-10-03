using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_and_Dustructor
{
    public class Constructor
    {
        public  Constructor()
        {
            Console.WriteLine("This is a default Constructor");
        }
    }

    public class ParaConst
    {
        int id;
        string name;
        public ParaConst(int i, string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructor c = new Constructor();

            ParaConst p = new ParaConst(2, "Pratik");
            p.display();
        }
    }
}
