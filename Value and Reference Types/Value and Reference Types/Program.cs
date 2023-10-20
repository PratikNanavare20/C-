using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_Reference_Types
{
    
    public class Program
    {
        //Value And Reference Type
        public static void value(int a, int b)
        {
            a = 10;
            b = 20;

            Console.WriteLine("The addition of values before changed is = "+(a + b));
        }

        //Pointer Type
        public string ProgramName { get;  set; }
        public static void info(Program name2)
        {
            name2.ProgramName = "Pratik";
        }

        static void Main(string[] args)
        {
            //Value And Reference Typee
            int a = 50;
            int b = 70;
            Console.WriteLine("The changed value of a is "+a);

            value(a,b);
            
            Console.WriteLine("The addition of values after changed is = " + (a + b));


            //Pointer Type
            Program name1 = new Program();
            name1.ProgramName = "Nanavare";

            info(name1);

            Console.WriteLine(name1.ProgramName);
        }
    }
}
