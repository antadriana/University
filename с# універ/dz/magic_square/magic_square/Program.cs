using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of square, please: ");
            int n = int.Parse(Console.ReadLine());
            int[] temp_arr1 = new int[n];
            int[] temp_arr2 = new int[2 * n - 1];
            int[,] matr = new int[n, n];
            int temp1 = n / 2 + 1;
            int temp2 = n;
            int temp3 = temp_arr2.Length / 2 + 1;
            int temp4 = temp_arr2.Length / 2 + 1;
            int temp5 = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                temp_arr1[i] = 0;
                // temp1--;

            }
            for (int i = n - 1; i >= 0; i = i - 2)
            {
                temp_arr1[i] = temp1;
                temp1--;

            }
            for (int i = n - 2; i > 0; i = i - 2)
            {
                temp_arr1[i] = temp2;
                temp2--;

            }

           /* for (int i = 0; i < n; i++)
            {
                Console.Write(temp_arr1[i]);
            }*/
            Console.WriteLine();
            
            for (int i = temp_arr2.Length - 1; i >= 0; i--)
            {
                temp_arr2[i] = 0;
            }
            for (int i = temp_arr2.Length - 1; i >= 0; i = i - 2)
            {
                temp_arr2[i] = temp3;
                temp3--;
            }
            for (int i = (temp_arr2.Length / 2 - 1); i > 0; i = i - 2)
            {
                temp_arr2[i] = temp4;
                temp4--;
            }
            for (int i = temp_arr2.Length / 2 + 1; i < temp_arr2.Length - 1; i += 2)
            {
                temp_arr2[i] = temp5;
                temp5++;
            }
          /*  for (int i = 0; i < temp_arr2.Length; i++)
            {
                Console.Write(temp_arr2[i]);
            }*/

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = 0;
                }
            }
       
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {

                    matr[i, j] = temp_arr2[i + j];

                }  
            }
            Console.WriteLine("Your Magic Square is:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
