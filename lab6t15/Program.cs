namespace lab6t15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n (>4): ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            int[] newArray = array.Take(n - 4).ToArray();
            Console.WriteLine("Массив без последних 4 элементов: " + string.Join(", ", newArray));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
