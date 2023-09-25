using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lOGICAL_PROGRAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sum of n number
            /*
            int n = 5;
            int sum = 0; 
                
            for (int i = 1; i <= n; i++)
            {
                sum=sum + i;
            }
            Console.WriteLine(sum);
            */

            //Find factorial
            int n = 7;
            int fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                if (i % 2 != 0)
                {
                    Console.WriteLine(fact);
                }
            }
        }
    }
}
