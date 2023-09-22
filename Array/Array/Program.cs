using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1D Array
            /*
            int[] arr1 = new int[4];
            arr1[0]= 10;
            arr1[2] = 20;
            arr1[3] = 30;

            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            

            //Multidimensional Array
            //2D
            int[,] arr2 = new int[3,3];
            arr2[0,2] = 10;
            arr2[2,0] = 20;
            arr2[1,0] = 30;

            for(int i= 0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(arr2[i,j] + " ");
                }
                Console.WriteLine();
            }
            
            //3D Array
            int[,,] arr3 = new int[3,3,3];
            arr3[0,1,2] = 10;
            arr3[2,0,1] = 20;
            arr3[2,1,0] = 30;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(arr3[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
            }
            
            //Jagged Array
            int[][] arr4 = new int[2][];

            arr4[0] = new int[] { 1, 2, 3, 4, };
            arr4[1] = new int[] { 5 , 6, 7, 8, 9, 0};

            for(int i = 0;i< arr4.Length; i++)
            {
                for(int j=0;j< arr4[i].Length; j++)
                {
                    Console.Write(arr4[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\n");
            */
            int[][] arr5 = new int[3][];

            arr5[0] = new int[] { 1, 2, 3, 4, };
            arr5[1] = new int[] { 5, 6, 7, 8, 9, 0 };
            arr5[2] = new int[] { 1, 2, 3 };

            for (int i = 0; i < arr5.Length; i++)
            {
                for (int j = 0; j < arr5[i].Length; j++)
                {
                    Console.Write(arr5[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
