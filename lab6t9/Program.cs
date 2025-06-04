namespace lab6t9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            bool allEven = array.All(x => x % 2 == 0);
            Console.WriteLine("Все элементы четные: " + allEven);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
