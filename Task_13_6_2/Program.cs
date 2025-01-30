namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\swnik\\Downloads\\cdev_Text.txt");

            char[] delimiters = new char[] { ' ', ',', '.', '-', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
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
            var sdict = new SortedDictionary<string, int>(dict);

            Console.WriteLine();

        }
    }
}
