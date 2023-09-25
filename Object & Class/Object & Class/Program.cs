using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object___Class
{
    public class Object
    {
        public long no;  //Initializing using public keyword
        public string add;



        //Initialize and display data through method
        public int no1;
        public int no2;

        public void insert(int a,int b)
        {
            no1 = a;
            no2 = b;
        }
        public void display()
        {
            Console.WriteLine(no1 + " " + no2);
        }
    }
    internal class Program
    {

        int id;
        string name;
        static void Main(string[] args)
        {
            
            Program p1 = new Program();
            p1.id = 101;
            p1.name = "Pratik";
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.id);

            //Object of Object class
            Object o1 = new Object();
            o1.no = 9284306284;
            o1.add = "Yeola";
            Console.WriteLine(o1.no);
            Console.WriteLine(o1.add);

            //Initialize and display data through method
            Object o2 = new Object();
            Object o3 = new Object();
            o2.insert(1, 2);
            o3.insert(3, 4);
            o2.display();
            o3.display();
     
        }
          
    }
}
