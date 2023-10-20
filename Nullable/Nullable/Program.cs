using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    public class Program
    {
        ///********************************
        public Nullable<int> i = null;
        
        ///********************
        public int? a = 20;
        public int b = 10;

        static void Main(string[] args)
        {    
            Program p = new Program();
            
            //**************************
            if(p.i == null)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                Console.WriteLine(p.i);
            }

            //***************************
            if (p.a == null)
            {
                Console.WriteLine("The Value of 'a' is NULL");
            }
            else
            {
                Console.WriteLine("Addition of the elements is "+(p.a + p.b));
                Console.WriteLine("Substraction of the elements is " + (p.a - p.b));
                Console.WriteLine("Multiplication of the elements is " + (p.a * p.b));
                Console.WriteLine("Division of the elements is " + (p.a / p.b));
            }
        }
    }
   
}
