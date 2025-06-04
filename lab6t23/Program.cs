namespace lab6t23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int DigitSum(int num)
            {
                int sum = 0;
                while (num != 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
            static int FirstDigit(int num)
            {
                while (num >= 10) num /= 10;
                return num;
            }
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
                int[] sumSorted = array.OrderBy(x => DigitSum(x)).ToArray();
                Console.WriteLine("Отсортировано по сумме цифр: " + string.Join(", ", sumSorted));
                int[] lastDigitSorted = array.OrderBy(x => x % 10).ToArray();
                Console.WriteLine("Отсортировано по последней цифре: " + string.Join(", ", lastDigitSorted));
                int[] firstDigitSorted = array.OrderBy(x => FirstDigit(x)).ToArray();
                Console.WriteLine("Отсортировано по первой цифре: " + string.Join(", ", firstDigitSorted));
                Console.WriteLine("Нажмите любую клавишу для выхода...");
                Console.ReadKey();
            }
        }
    }
}
