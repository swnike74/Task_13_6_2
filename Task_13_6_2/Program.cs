using System.Linq;

namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\swnik\\Downloads\\cdev_Text.txt");

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            char[] delimiters = new char[] { ' ', ',', '.', '-', '\r', '\n' };
            var words = noPunctuationText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            // выводим количество
            Console.WriteLine($"Кол-во слов в массиве {words.Length}");

            var booklist = new List<string>();
            var linkedbooklist = new LinkedList<string>();

            foreach (var word in words)
            {
                booklist.Add(word);
                linkedbooklist.AddLast(word);
            }
            Console.WriteLine($"Кол-во слов в списке {booklist.Count}");

            // Создаем хэш-сет, передавая в конструктор наш массив
            HashSet<string> hSet = new HashSet<string>(words);
            Console.WriteLine("Длина хэш-сета " + hSet.Count);

            var digit = new[] {"1","2", "3","4","5","6","7","8","9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26" };
            hSet.ExceptWith(digit);
            Console.WriteLine("Длина хэш-сета без цифр " + hSet.Count);

            var dict = new Dictionary<string, int>();
            foreach (var item in booklist)
            {
                if(dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }
            
            var t = dict.Values;
            var s = dict.Keys;
            
            var dict2 = new Dictionary<int, string>();
            int j = 0;
            string st;
            for (int i = 0; i < 20; i++)
            {
                int max = -100;
                string keymax = "";
                foreach (var item in dict.Keys)
                {
                    var dig = dict[item];
                    if (dig > max)
                    {
                        max = dig;
                        keymax = item;
                    }
                }
                Console.WriteLine($"Место {j.ToString()}: Слово {keymax} ,количество в тексте:  {max.ToString()}");
                j++;
                dict.Remove(keymax);
            }
            var sdict = new SortedDictionary<string, int>(dict);

            Console.WriteLine();

        }
    }
}
