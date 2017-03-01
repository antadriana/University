using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_square2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the size of the square: ");
            int size = int.Parse(Console.ReadLine());
            int value = 2;

            int cur_i = 0; int cur_j = size / 2;
            int i = cur_i; int j = cur_j;

            int[,] Matrix = new int[size, size];
            Matrix[cur_i, cur_j] = 1;


            for (int i1 = 0; i1 < size; i1++)
            {
                for (int j1 = 0; j1 < size; j1++)
                    Console.Write("{0} ", Matrix[i1, j1]);
                Console.Write("\n");
            }

            //Console.WriteLine(Matrix[1, 1]);

            while (value != size * size + 1)
            {
                i--;
                if (i < 0)
                    i = size - 1;
                j++;
                if (j > size - 1)
                    j = 0;

                Console.WriteLine("{0} / {1}", i, i);


                if (Matrix[i, j] == 0)
                {
                    Matrix[i, j] = value;
                    cur_i = i; cur_j = j;
                    value++;
                }
                else
                {
                    if (cur_i++ > size - 1)
                        cur_i = 0;
                    Matrix[cur_i, cur_j] = value;
                    value++;
                    i = cur_i; j = cur_j;
                }
                for (int i1 = 0; i1 < size; i1++)
                {
                    for (int j1 = 0; j1 < size; j1++)
                        Console.Write("{0} ", Matrix[i1, j1]);
                    Console.Write("\n");
                }
                Console.WriteLine();


            }
            for (int i1 = 0; i1 < size; i1++)
            {
                for (int j1 = 0; j1 < size; j1++)
                    Console.Write("{0} ", Matrix[i1, j1]);
                Console.Write("\n");
            }

        }
    }
}
