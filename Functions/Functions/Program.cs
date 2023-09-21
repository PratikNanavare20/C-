using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    internal class Program
    {
        //Non Parameterized Function
        public void fun1()
        {
            Console.WriteLine("This is function");
        }

        //Parameterized Function
        public void fun2(int a, int b) 
        {
            Console.WriteLine("The addition is " + (a + b));
        }

        //Call by value
        public void fun3(int val)
        {
            val += val;
            Console.WriteLine("Value inside the function "+val);
        }

        //call by reference
        public void fun4(ref int val)
        {
            val += val;
            Console.WriteLine("Value inside the function " + val);
        }

        //out  parameter 
        public void fun5(out int val)
        {
            int square = 5;
            val = square;
            val += val;
            Console.WriteLine("Value inside the function " + val);
        }
        static void Main(string[] args)
        {
            int val = 50;
            Program p1 = new Program();
            p1.fun1();
            p1.fun2(1, 2);

            Console.WriteLine("Value before calling the function "+val);
            p1.fun3(val);
            Console.WriteLine("Value after calling the function " + val); // calling initial value when we are using call by value

            Console.WriteLine("Value before calling the function " + val);
            p1.fun4(ref val);
            Console.WriteLine("Value after calling the function " + val); //calling function value when we are using call by reference

            Console.WriteLine("Value before calling the function " + val);
            p1.fun5(out val);
            Console.WriteLine("Value after calling the function " + val);


        }
    }
}
