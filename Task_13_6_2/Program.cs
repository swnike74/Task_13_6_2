using System.Linq;

namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\swnike\\Downloads\\cdev_Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            char[] delimiters = new char[] { ' ', ',', '.', '-', '\r', '\n' };
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine($"Кол-во слов в массиве {words.Length}");

            var booklist = new List<string>();

            foreach (var word in words)
            {
                booklist.Add(word);
            }
            Console.WriteLine($"Кол-во слов в списке {booklist.Count}");

            var dict = new Dictionary<string, int>();
            foreach (var item in booklist)
            {
                if(dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            
            int j = 0;
            for (int i = 0; i < 10; i++)
            {
                int max = -100;
                string keymax = "";
                foreach (var item in dict.Keys)
                {
                    var quantwords = dict[item];
                    if (quantwords > max)
                    {
                        max = quantwords;
                        keymax = item;
                    }
                }
                Console.WriteLine($"Место {j.ToString()}: Слово {keymax} ,количество в тексте:  {max.ToString()}");
                j++;
                dict.Remove(keymax);
            }
            Console.WriteLine();
        }
    }
}
