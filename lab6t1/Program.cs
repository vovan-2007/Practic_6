namespace lab61t
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.Write("Введите число M: ");
            int M = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = M;
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
