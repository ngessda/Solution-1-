using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
    /* Trash
                string dirName = "D:\\";
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Подкаталоги:");
                    string [] dirs = Directory.GetDirectories(dirName);
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(dir);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();

                string dirName = "D:\\ProgramResources";
                if (Directory.Exists(dirName))
                {
                    Console.WriteLine("Yes.");
                }
                else
                {
                    Console.WriteLine("Creating...");
                    Directory.CreateDirectory(dirName);
                    Console.WriteLine("Done.");
                }
                Console.ReadKey();

                string problem = "AaA";
                int index = problem.IndexOf("A");
                Console.WriteLine(index);
                int lastIndex = problem.LastIndexOf("A");
                Console.WriteLine(lastIndex);
                Console.ReadKey();

                string word = "Kill Niggers";
                for(int i = 0; i < word.Length; i++)
                {
                    Console.WriteLine(word[i]);
                }
                Console.ReadKey();

                string[] vs = { "ACCАаАBbbbCCC", "aаaBBBccc", "abc" };
                for (int i = 0; i < vs.Length; i++)
                {
                    if (vs[i].ToLower().StartsWith("a") && vs[i].ToLower().EndsWith("c"))
                    {
                        Console.WriteLine(vs[i]);
                    }
                    else
                        continue;
                }
                Console.ReadKey();
            string dirName = "D:\\testing";
            string filePath = dirName + "\\test.txt";
            string text = "Hello World!";
            Directory.CreateDirectory(dirName);
            FileInfo Infofile = new FileInfo(filePath);
            File.WriteAllText(filePath, text);
            text = File.ReadAllText(filePath);
            Console.WriteLine(text);
            Console.ReadLine();



            bool flag;
            string dirName = "D:\\testing";
            string filePath = dirName + "\\test.txt";
            string [] text = { "abcdef", "аргентинаманитнегра", "aaabbbaaa", "ggghggge", "pppoooppp", "яаркакрая"};
            Directory.CreateDirectory(dirName);
            FileInfo Infofile = new FileInfo(filePath);
            File.WriteAllText(filePath, "");
            for(int i = 0; i < text.Length; i++)
            {
                int lastIndex = text[i].Length - 1;
                flag = true;
                if(text[i].Length % 2 == 0)
                {
                    for (int j = 0; j < text[i].Length; j++)
                    {
                        if (text[i][j] == text[i][lastIndex - j] && j <= lastIndex / 2)
                        {
                            continue;
                        }
                        else if(text[i][j] != text[i][lastIndex - j] && j <= lastIndex / 2)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < text[i].Length; j++)
                    {
                        if (text[i][j] == text[i][lastIndex - j] && j < lastIndex / 2)
                        {
                            continue;
                        }
                        else if (text[i][j] != text[i][lastIndex - j] && j <= lastIndex / 2)
                        {
                            flag = false;
                            break;
                        }
                    }
                }
                if (flag == true)
                {
                    File.AppendAllText(filePath, "\n" + text[i] + " = палиндром");
                }
                else if(flag == false)
                {
                    File.AppendAllText(filePath, "\n" + text[i] + " = непалиндром");
                }
            }
            Console.ReadLine();



                string text = "car_cat_ball_house_yellow_ice-cream";
            string [] words = text.Split(new char[] { '_' });
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            int length = words.Length;
            Console.WriteLine(length);
            Console.ReadKey();


                string text = "_car_cat_ball_house_yellow_ice-cream_";
            string[] words = text.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            int length = words.Length;
            Console.WriteLine(length);
            Console.ReadKey();

                string text = "_car_cat_ball_house_yellow_ice-cream_";
            text = text.Trim(new char[] { '_' });
            string[] words = text.Split(new char[] { '_' });
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            int number = words.Length;
            Console.WriteLine(number);
            Console.ReadKey();
    */
}
