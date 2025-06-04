namespace lab6t16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(10, 30);
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            int[] newArray = array.SkipWhile(x => x < 20).ToArray();
            Console.WriteLine("Массив после пропуска элементов <20: " + string.Join(", ", newArray));
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
