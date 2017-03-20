using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Split_String_by_Separators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your string");
            string line = Console.ReadLine();
            string newLine = "";
            string separators = ".,!:' '";
            for (int i = 0; i < separators.Length; i++)
            {
                if (line.Contains(separators[i]))
                {
                    newLine = line.Replace(separators[i], ' ');
                    line = newLine;
                }
            }
            // Console.WriteLine(newLine);
            //string result = newLine.Trim('*');

            string[] word = newLine.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != "")
                {
                    word[i] = (word[i].Remove(1, word[i].Length - 1)).ToUpper() + word[i].Remove(0, 1);
                    Console.WriteLine(word[i]);
                }
            }
        }
    }
}
