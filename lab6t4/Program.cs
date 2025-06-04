namespace lab6t4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[17];
            Random rnd = new Random();
            int sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 100);
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));

            foreach (int num in array)
            {
                if (num > 0 && num % 2 != 0)
                {
                    sum += num;
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Среднее значение нечетных положительных элементов: {(double)sum / count}");
            }
            else
            {
                Console.WriteLine("Нет нечетных положительных элементов");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
