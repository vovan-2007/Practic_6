namespace lab6t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] fibArray = new int[n];
            if (n >= 1) fibArray[0] = 0;
            if (n >= 2) fibArray[1] = 1;
            for (int i = 2; i < n; i++)
            {
                fibArray[i] = fibArray[i - 1] + fibArray[i - 2];
            }
            Console.WriteLine("Числа Фибоначчи: " + string.Join(", ", fibArray));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
