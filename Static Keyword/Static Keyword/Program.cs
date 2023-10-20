using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Static_Keyword
{
    //Static variables
    public class Example1
    {
        static int id = 10; //Static variables only access within class
        static string fname = "Pratik";
        static string lname = "Nanavare";

        public void info()
        {
            Console.WriteLine(id + " " + fname + " " + lname);
        }
    }

    //Static Method
    public class Example2
    {
        public static int a = 10;
        public static int b = 10;
        static void add()
        {
            Console.WriteLine(a + b);
        }
    }

    //Static Class
    public static class Example3
    {
        public static int a = 4;
        public static int b = 4;
    }

    //Static Constructor
    public class Example4
    {
        public string fname;
        public string lname;
        public static string addr;

        public Example4(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
        static Example4()
        {
            addr = "Yeola";
        }
        public void display()
        {
            Console.WriteLine(fname + " " +lname+" "+addr) ;
        }
    }
internal class Program
    {
        static void Main(string[] args)
        {
            //Static variables
            Example1 e = new Example1();
            e.info();

            //Static Methods
            Example2 e2 = new Example2();
            //e2.add();                     //static method is not access outside the class


            //Static Class
            //  Example3 e3 = new Example3();       //static class dose not create object of that class

            Console.WriteLine(Example3.a);
            Console.WriteLine(Example3.b);

            //Static Constructor
            Example4 e4 = new Example4("Pratik","Nanavare");
            e4.display();
        }
    }
}
