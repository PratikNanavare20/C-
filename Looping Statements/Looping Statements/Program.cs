using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Loop
            /*
            int i;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            //Nested For Loop
            /*
            int i, j;
            for(i= 0; i <=5;i++)
            {
                for(j= 0; j <=5;j++)
                {
                    Console.WriteLine(i+" "+j);
                }
            }
            */

            //infinite For Loop
            /*
            for (; ;)
            {
                Console.WriteLine("Infinite for loop");
            }
            */

            //While Loop
            /*
            int i = 0;
            while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            //Nested While Loop
            /*
            int i = 0;
            while (i <= 10)
            {
                int j = 1;
                while (j < 5)
                {
                    Console.WriteLine(i+" "+j);
                    j++;
                }
                i++;
            }
            */


            //infinite While Loop
            /*
            int i = 0;
            while(true)
            {
                Console.WriteLine("Infinite loop");
                i++;
            }
            */

            //Do while loop
            /*
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);
            */


            //Break Statement
            /*
            int i;
            for(i=0;i<5;i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */

            //Continue Statement
            int i,j;
            for (i = 0; i < 6; i++)
            {
                for(j = 0;j< 5; j++)
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    Console.WriteLine(i+" "+j);
                }
               
            }

        }
    }
}
