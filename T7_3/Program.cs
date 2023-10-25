using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Task 1
                //Find the longest word out of five words entered from the keyboard.

                /*string st = "";
                int l = st.Length;
                string s = "";

                for (int i = 0; i < 5; i++)
                {
                    Write($"Enter {i+1} word: ");
                    string st1 = ReadLine();
                    if (st1.Length > l)
                    {
                        l = st1.Length;
                        s = st1;
                    }
                }

                WriteLine($"The longest word is {s}, it's have {l} symbols.");*/


                //Task 2
                //Make a program that removes the letter "e" ("E") from a sentence.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    if (sentence[i] == 'е')
                    {
                        sentence = sentence.Replace("е", "");
                    }
                    if (sentence[i] == 'Е')
                    {
                        sentence = sentence.Replace("Е", "");
                    }
                }
                WriteLine(sentence);*/


                //Task 3
                //Make a program to calculate the number of letters "a"("A") in a sentence.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                int letter_a = sentence.Split('a', 'A', 'а', 'А').Length - 1;
                WriteLine($"\nThe number of letters: {letter_a}");*/


                //Task 4
                //Make a program that determines the length of the first word in a sentence.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                int i = 0;
                while (sentence[i] != ' ')
                {
                    i++;
                }
                WriteLine($"The length of the first word: {i}");*/


                //Task 5
                //Make a program that determines the length of the last word in a sentence.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                int count = 0;
                for (int i = sentence.Length - 1; i >= 0; i--)      //НЕРАБОЧИЙ КОД
                {
                    if (sentence[i] != ' ')
                    {
                        count++;
                    }
                }
                Write(count);*/


                //Task 6
                //Make a program that replaces the letter "a" ("A") with "o" ("O") in a sentence.

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    if (sentence[i] == 'а')
                    {
                        sentence = sentence.Replace("а", "о");
                    }
                    if (sentence[i] == 'А')
                    {
                        sentence = sentence.Replace("А", "О");
                    }
                }
                WriteLine(sentence);*/


                //Task 7
                //Write a program to get the reversed string.

                /*Write("Enter a word: ");
                string word = ReadLine();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    Write(word[i]);
                }*/
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
