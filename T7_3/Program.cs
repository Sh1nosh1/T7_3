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
                /*string st = "";
                int l = st.Length;

                string s = "";
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"");
                    string st1 = Console.ReadLine();
                    if(st1.Length > l)
                    {
                        l = st1.Length;
                        s = st1;
                    }
                }
                Console.WriteLine(l);
                Console.WriteLine(s);
                Console.ReadLine();*/


                /*Write("Enter a sentence: ");      
                string sentence = ReadLine();
                string trim = sentence.Trim();
                int words = trim.Split(' ').Length;     
                WriteLine($"\nThe quantity of words: {words}");*/


                //Из строки удалить букву "е"

                /*Write("Enter a sentence: ");
                string sentence = ReadLine();
                sentence = sentence.Replace('E', ' ');
                sentence = sentence.Replace('e', ' ');
                sentence = sentence.Replace('е', ' ');
                sentence = sentence.Replace('Е', ' ');
                Write(sentence);*/


                /*string sentence = ReadLine();
                //char r = ' ';
                for(int i = 0; i < sentence.Length-1; i++)
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

                //Заменить в строке букву А на букву О

                /*string sentence = ReadLine();
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




                //3
                //Составьте программу вычисления количества букв «а» («А») в предложении.

                /*Write("Enter a word: ");     
                string word = ReadLine();
                int letter_a = word.Split('a', 'A', 'а', 'А').Length - 1;    
                WriteLine($"\nThe number of letters: {letter_a}");*/

                //7
                //Написать программу для получения реверсированной строки.

                /*string word = ReadLine();
                for(int i = word.Length-1; i >= 0; i--)
                {
                    Write(word[i]);
                }*/

                //Задача 4. Составьте программу, определяющую длину первого слова в предложении.

                /*string sentence = ReadLine();
                int i = 0;
                while (sentence[i] != ' ')
                {
                    i++;
                }
                WriteLine(i);*/

                //Задание 5
                // Составьте программу, определяющую длину последнего слова в предложении.
                //string sentence = ReadLine();
                //int count = 0;
                //for (int i = sentence.Length - 1; i >= 0; i--)
                //{
                //    if (sentence[i] != ' ')
                //    {
                //        count++;
                //    }
                //}
                //Write(count);

                /*string sentence = ReadLine();
                int i = sentence.Length-1;
                while (sentence[i] != ' ')
                {
                    i--;
                }
                WriteLine(i+1);*/



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
