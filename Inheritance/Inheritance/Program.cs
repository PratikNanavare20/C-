using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Single Inheritance
    /*
    public class Parent
    {
        public int id = 10;
        public Parent() 
        {
            Console.WriteLine("parent class");
        }
    }
    public class Child:Parent
    {
        public string name = "Pratik";
        public Child()
        {
            Console.WriteLine("This is Child class");
        }
    }
    */
   
    //Multi Level Inheritance
    public class Student
    {
        public int Id = 101;
        public string Name = "Pratik";
        public string Addr = "Yeola";
        public void stdinfo()
        {
            Console.WriteLine("Student Info");
        }
       
    }

    public class Collage : Student
    {
        public string clg = "SND";
        public string branch = "Computer";
        public void clginfo()
        {
            Console.WriteLine("Collage Info");
        }
    }

    public class University:Collage
    {
        public string uni = "SPPU";

        public void uniinfo()
        {
            Console.WriteLine("University Info");
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Child c = new Child();
            Console.WriteLine("The id is : " + c.id);
            Console.WriteLine("The name is :- "+c.name);
            */


            University u = new University();
            u.stdinfo();
            Console.WriteLine(u.Id+" "+u.Name+" "+u.Addr);
            u.clginfo();
            Console.WriteLine(u.clg + " " + u.branch);
            u.uniinfo();
            Console.WriteLine(u.uni);
            
        }
    }
}
