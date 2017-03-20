using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubling_letters_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
           // string line = "mommy daddy cold daily darling nutty";
            string newLine = "";
            string separators = ".,:!";
                       for (int i = 0; i < separators.Length; i++)
            {
                if (line.Contains(separators[i]))
                {
                    newLine = line.Replace(separators[i], ' ');
                    line = newLine;
                }
                else newLine = line;
            }
            string wordsWithDoublingLetters = "";
           // Console.WriteLine(newLine);
            string[] temp = newLine.Split(' ');
           /* for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i] );
            }*/
            for (int i=0;i<temp.Length; i++)
            { for(int j=0;j<temp[i].Length-1; j++)
                {
                    if (temp[i][j] == temp[i][j + 1]) {
                        wordsWithDoublingLetters += (temp[i] + " ");
                    }
                }
                
            }
            Console.WriteLine("Words with doubling letters are: \n"+wordsWithDoublingLetters);
        }
    }
}
