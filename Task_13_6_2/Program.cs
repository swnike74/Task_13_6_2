namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\swnike\\Downloads\\cdev_Text.txt");

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



        }
    }
}
