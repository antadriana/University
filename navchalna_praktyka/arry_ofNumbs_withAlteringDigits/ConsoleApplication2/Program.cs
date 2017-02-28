using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {    static bool Test( int a)
        {
                     
                if (a / 10 == 0) return true; // если число <10, то посчитать его правильным(вернуть верно)
            while (a / 10 != 0)
            { // пока число не станет меньше 10
                if ((a % 10) % 2 != ((a % 100) / 10) % 2) // если цифра единиц имеет такую же чётность как и цифра десятков
                    a /= 10; // отбрасываем самую правую цифру, число сотен становится десятками и т.д.
                else return false;
            }
                // иначе считаем число неправильным, вернуть ложь
                return true;
            
            }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int kst = b - a;
            int[] arr = new int[kst];
            int num = 0;
            for (int i = a; i < b; i++)
            {
                arr[num] = i;
                num += 1;
            }
            Console.WriteLine("your array is:");
            for (num = 0; num < kst; num++)
            {
                Console.Write(arr[num] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numbers with altering digits are:");
            for (num = 0; num < kst; num++)
            {
                if (Test(arr[num]) == true)
                {
                    Console.Write(arr[num]+" ");
                }
                else Console.Write("");
            }
            Console.WriteLine();
        }
    }
}
