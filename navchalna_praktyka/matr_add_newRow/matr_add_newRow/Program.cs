using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matr_add_newRow
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the size of matrix, please");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
           

            int[,] matr = new int[n, m];
            int[,] matr2 = new int[n+1, m];
            Console.WriteLine("Enter the elements of your matrix:" );

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
                    Console.WriteLine("Your matrix is:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }int minn = matr[0, 0];
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    if (minn > matr[i, j])
                    {
                        minn = matr[i, j];
                        temp = i;
                    }
                    
                }
            }
         //   Console.WriteLine("The minimum is:" +minn+"  temp  "+temp);

            for(int i=0; i<n+1; i++)
            {
                for (int j=0; j<m; j++)
                {
                    matr2[i, j] = 0;
                    
                }  }
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr2[i, j] = matr[i, j];
                }
            }

            for (int i = n; i > temp; i--)
                for (int j = 0; j < m; j++)
                {
                    {
                        matr2[i, j] = matr2[i - 1, j];
                      }
                }
            for (int i = 0; i < n + 1; i++)
            {
                for (int j = 0; j < m; j++) {
                    if (i == temp) { matr2[i+1, j] = 0; } }
            }

                    Console.WriteLine("Your new matrix is:");

            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr2[i, j] + " ");
                }
                Console.WriteLine();

            }
    }
} 
    }