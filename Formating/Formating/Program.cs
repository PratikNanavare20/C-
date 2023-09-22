using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 5;
            int f1 = 0;
            int f2 = 1;
            int f3;


            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 0; i <= no; i++)
            {      
                f3 = f2 + f1;
                f1 = f2;
                f2 = f3;
                Console.WriteLine(f3);
            }
        }
    }
}
