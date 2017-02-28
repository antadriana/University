 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {static void Swap1(ref int a, ref int b){
            int temp = a;
            a = b;
            b = temp;
       Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;
            //Swap1(ref a, ref b);
            int size = 10;
            int[] arr = new int[10];
            Random r = new Random();
            for (int i=0; i<size; i++)
            {
                arr[i] = r.Next(0, 10);
                Console.WriteLine(arr[i]);
            }
             /*int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int sum = num + num1;
            Console.WriteLine("Sum is "+sum);*/
            // int[] temp = { 2, 3 };
            // int[] temp2 = new int[10];
            //  int temp1[] = { 2, 3 };
           /* int[][] temp = new int[5][];
            for (int i=0; i<5; ++i)
            {
                temp[i] = new int[i + 1];
                temp[i][] = 1;
                
            }
            for (int i = 3; i < 5; ++i)
            {
                temp[i] = new int[3];
               
            }
             Console.WriteLine(temp);*/
            
             } 
    }
}
