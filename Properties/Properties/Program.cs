using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Values
    {
        private string name;

        public string Name 
        { 
            get 
            { 
                return name; 
            } 
            set 
            {
                //name = value;
                name = value + " Nanavare";
            } 
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Values v = new Values();
            v.Name = "Pratik";
            Console.WriteLine("My Full name is "+v.Name);  
        }
    }
}
