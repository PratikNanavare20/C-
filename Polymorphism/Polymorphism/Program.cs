using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Method Overloading
    public class arthOperations
    { 
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static float add(int a ,float b , int c)
        {
            return a + b + c;
        }
    }

    //Method Overriding
    public class Animal
    {
        public virtual void info()
        {
            Console.WriteLine("Name of animal is Dog");
        }
    }
    public class AnimalName:Animal
    {
        public override void info()
        {
            Console.WriteLine("Name of animal is Cat");
        }
    }

    //Base class field
    public class Color
    {
        public string color = "Pink";
    }
    public class ColorName : Color
    {
        public string color = "Red";
        public void info1()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Overloading :- \n");
            Console.WriteLine("\nThe addition of two number is = "+arthOperations.add(2,3));
            Console.WriteLine("\nThe addition of three number is = " + arthOperations.add(2, 3.05f, 5)+"\n");

            Console.WriteLine("Overriding :- \n");
            AnimalName a1 = new AnimalName();
            Animal a2 = new AnimalName();
            Animal a3 = new Animal();
            a1.info();
            a2.info();
            a3.info();

            Console.WriteLine("\nThis is base class :-");
            ColorName c = new ColorName();
            c.info1();
        }
    }
}
