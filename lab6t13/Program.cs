namespace lab6t13
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
                array[i] = rnd.Next(1, 10);
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            int[] newArray = array.Select(x => x * x).ToArray();
            Console.WriteLine("Массив с квадратами: " + string.Join(", ", newArray));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
