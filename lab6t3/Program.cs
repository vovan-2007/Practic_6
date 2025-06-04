namespace lab6t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random rnd = new Random();
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0 && array[i] < 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"Сумма отрицательных элементов на нечетных местах: {sum}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
