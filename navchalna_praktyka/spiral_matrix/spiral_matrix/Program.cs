using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spiral_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of matrix, please:");
            int n = int.Parse(Console.ReadLine());
            int[,] matr = new int[n, n];

            int temp = 1;

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = 0;
                }
            }


            for (int k = 1; k <= n / 2 + 1; k++)
            {
                for (int j = k - 1; j < n - k + 1; j++)
                {
                    matr[k - 1, j] = temp;
                    temp++;

                }
                for (int j = k; j < n - k + 1; j++)
                {
                    matr[j, n - k] = temp++;
                }
                for (int j = n - k - 1; j >= k - 1; j--)
                {
                    matr[n - k, j] = temp++;
                }
                for (int j = n - k - 1; j >= k; j--)
                {
                    matr[j, k - 1] = temp++;
                }


            }




            Console.WriteLine("Your Matrix is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] +"\t ");
                }
                Console.WriteLine();
            }

        }
    }
}
