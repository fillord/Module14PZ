using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14PZ
{
    internal class Program
    {
        static void Main()
        {
            string text = "Синий небесный океан огромен и глубок. Ярко-синий океан завораживает своими волнами. Океан вдохновляет на свободу и приключения. Глубокий океан таинственен и прекрасен. Небесный светлый океан манит своей красотой. Великий океан полон загадок и чудес. Океан великолепен в своей бескрайности. Синий океан - это мир таинственных глубин. Вода океана обладает уникальной силой. На берегу океана вдыхаешь свежий воздух.";
            Dictionary<string, int> wordFrequency = CountWordFrequency(text);
            DisplayStatistics(wordFrequency);
        }

        static Dictionary<string, int> CountWordFrequency(string text)
        {
            string[] words = text.Split(new[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequency = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string normalizedWord = word.ToLower(); 

                if (frequency.ContainsKey(normalizedWord))
                {
                    frequency[normalizedWord]++;
                }
                else
                {
                    frequency[normalizedWord] = 1;
                }
            }

            return frequency;
        }

        static void DisplayStatistics(Dictionary<string, int> statistics)
        {
            Console.WriteLine("{0,-15} | {1,-5}", "Слово", "Частота");

            foreach (var pair in statistics.OrderByDescending(p => p.Value))
            {
                Console.WriteLine("{0,-15} | {1,-5}", pair.Key, pair.Value);
            }
        }
    }
}
