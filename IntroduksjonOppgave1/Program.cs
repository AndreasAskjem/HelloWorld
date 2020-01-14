using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduksjonOppgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadTextAndUpdateAndShowCharCounts(250);
        }

        private static void ReadTextAndUpdateAndShowCharCounts(int range)
        {
            var totalNumberOfChars = 0;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                text = text.ToLower();
                UpdateCharCounts(counts, text);

                totalNumberOfChars += text.Length;
                ShowCounts(range, totalNumberOfChars, counts);
            }
        }

        private static void ShowCounts(int range, int totalNumberOfChars, int[] counts)
        {
            for (var i = 0; i < range; i++)
            {
                if (counts[i] > 0)
                {
                    var character = (char)i;
                    var percentage = counts[i] * 100 / totalNumberOfChars;
                    string output = character + " - " + percentage + "%";
                    Console.CursorLeft = Console.BufferWidth - output.Length - 1;
                    Console.WriteLine(output);
                }
            }
        }

        private static void UpdateCharCounts(int[] counts, string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                counts[(int)character]++;
            }
        }
    }
}
