namespace lab6t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[8];
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());

                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"Среднее арифметическое положительных элементов: {sum / count}");
            }
            else
            {
                Console.WriteLine("Нет положительных элементов");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
