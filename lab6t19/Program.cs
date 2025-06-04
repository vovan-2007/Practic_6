namespace lab6t19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };
            int[] OneNoTwo = array1.Except(array2).ToArray();
            Console.WriteLine("19.1. Элементы в первом, но не во втором: " + string.Join(", ", OneNoTwo));
            int[] obshac = array1.Intersect(array2).ToArray();
            Console.WriteLine("19.2. Общие элементы: " + string.Join(", ", obshac));
            int[] NeObshac = array1.Union(array2).Except(obshac).ToArray();
            Console.WriteLine("19.3. Объединение без общих элементов: " + string.Join(", ", NeObshac));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
