namespace lab6t21
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
                array[i] = rnd.Next(1, 100);
            }
            Console.WriteLine("Исходный массив: " + string.Join(", ", array));
            Console.Write("Введите количество элементов для сдвига (m): ");
            int m = int.Parse(Console.ReadLine());
            m = m % n;
            int[] sdvgArray = array.Skip(m).Concat(array.Take(m)).ToArray();
            Console.WriteLine($"Массив после сдвига на {m} элементов: " + string.Join(", ", sdvgArray));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
