using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reapeated_words__in_String
{
    class Program
    {
        static void Main(string[] args)
        {
             string str = "Hello, hello, my name ok is Adriana. It is very good name.ok.Today yes yes i go My ADRIANA";
           // string str = Console.ReadLine();
            string nStr = str.ToLower();
            string separators = ".,:!";
            string newStr = "";
            for (int i = 0; i < separators.Length; i++)
            {
                if (str.Contains(separators[i])) { newStr=nStr.Replace(separators[i], ' ');
                    nStr=newStr;
                }
            }
          
            string[] temp = newStr.Split(' ');
           string repeatedWords ="";
            for(int j=0;j<temp.Length; j++)
            {
                for (int i = j+1; i < temp.Length; i++)
                {
                    if (temp[j] == temp[i])
                    {if(temp[i]!="")
                    repeatedWords+=(temp[i]+ " ");
                        break;
                    } 
                 }
            }
            Console.WriteLine("Words that are repeated in string:\n" +repeatedWords);
        }
    }
}
