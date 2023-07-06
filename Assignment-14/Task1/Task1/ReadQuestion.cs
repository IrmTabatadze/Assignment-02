using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ReadQuestion
    {
        public ReadQuestion() 
        { 
        }
        public static string ReadQuestions(string path)
        {
            var Sourse = File.ReadLines(path);
            int MyScore = 0;
            int Score = 0;

            foreach (var item in Sourse)
            {
                if (item.Contains("kiTxva:"))
                    Console.Write(item);
                if (item.Contains("qula:"))
                {
                    string s = item;
                    string delimiter = "kitxvis qula: ";

                    string[] substrings = s.Split(delimiter);
                    foreach (string substring in substrings)
                    {
                        if (substring != "")
                            MyScore = int.Parse(substring);
                    }
                }

                if (item.Contains("pasuxi 1") || item.Contains("pasuxi 2") || item.Contains("pasuxi 3"))
                {
                    Console.WriteLine("\n" + item);

                }
                if (item.Contains("swori pasuxi"))
                {
                    Console.WriteLine("\nSheikvanet swori pasuxi: ");
                    var answer = Console.ReadLine();
                    if (answer == null)
                    {
                        Console.WriteLine("gTxovT Sheikvanot swori pasuxi: ");
                    }
                    else if (item.Contains(answer))
                    {
                        Score = Score + MyScore;
                    }
                }
            }

            if (MyScore > 0)
            {
                var result = "\nYour total Score is: " + Score;
                return result;
            }
            else
            {
                return "\nYour total Score is: " + 0;
            }
        }
    }
}
