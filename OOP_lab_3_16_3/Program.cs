using System;
using System.IO;

namespace OOP_lab_3_16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("input.txt");

            StreamWriter output = File.CreateText("output.txt");

            string text = input.ReadToEnd();

            string[] words = text.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            text = "";

            foreach (string word in words)
            {
                text += word + " ";
            }

            int max = 0;
            string longestWord = "";

            foreach (string word in words)
            {
                int k = 0;

                foreach(char letter in word)
                {
                    if ((letter == 'A') || (letter == 'E') || (letter == 'I') || (letter == 'O') || (letter == 'U') || (letter == 'Y')) ++k;
                    if ((letter == 'a') || (letter == 'e') || (letter == 'i') || (letter == 'o') || (letter == 'u') || (letter == 'y')) ++k;
                    if ((letter == 'А') || (letter == 'О') || (letter == 'У') || (letter == 'И') || (letter == 'І') || (letter == 'Е') || (letter == 'Я') || (letter == 'Ю') || (letter == 'Є') || (letter == 'Ї')) ++k;
                    if ((letter == 'а') || (letter == 'о') || (letter == 'у') || (letter == 'и') || (letter == 'і') || (letter == 'е') || (letter == 'я') || (letter == 'ю') || (letter == 'є') || (letter == 'ї')) ++k;
                }

                if (max <= k)
                {
                    max = k;
                    longestWord = word;
                }
            }

            output.WriteLine(text);
            output.WriteLine("Cлово, що мiстить найбiльшу кiлькiсть голосних лiтер: {0}", longestWord);

            output.Close();
        }
    }
}
