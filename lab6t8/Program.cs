namespace lab6t8
{
    internal class Program
    {
        static int Factorial(int k)
        {
            int result = 1;
            for (int i = 2; i <= k; i++) result *= i;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            double[] array1 = new double[n];
            for (int i = 0; i < n; i++)
            {
                array1[i] = Math.Pow(-1, i) / (i + 1);
            }
            Console.WriteLine("Сумма: " + array1.Sum());

            Console.Write("Введите x для задачи 8.2: ");
            double x = double.Parse(Console.ReadLine());
            double[] array2 = new double[n];
            for (int i = 0; i < n; i++)
            {
                array2[i] = Math.Pow(x, 2 * i + 1) / (2 * i + 1);
            }
            Console.WriteLine("Сумма: " + array2.Sum());

            double[] array3 = new double[n];
            for (int i = 0; i < n; i++)
            {
                array3[i] = 1.0 / Factorial(i + 1);
            }
            Console.WriteLine("8.3 Сумма: " + array3.Sum());
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
