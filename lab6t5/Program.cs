namespace lab6t5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine("5.1. Сумма элементов с четными индексами: " + sumChetniyIndex(array));
            Console.WriteLine("5.2. Минимальный положительный элемент: " + MinimalPlus(array));
            Console.WriteLine("5.3. Сумма максимального и минимального элементов: " + (MaxEl(array) + MinEl(array)));
            Console.WriteLine("5.4. Количество положительных элементов: " + PlusCount(array));

            Console.Write("Введите a и b для задачи 5.5: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("5.5. Сумма четных положительных с индексами от a до b: " + sumChetPlusIndexab(array, a, b));
            Console.WriteLine("5.6. Среднее значение четных элементов: " + PlusAvg(array));
            Console.WriteLine("5.7. Сумма четных положительных элементов: " + sumChetPlus(array));
            Console.WriteLine("5.8. Сумма неотрицательных на четных местах: " + sumZeroPlusOnChetPos(array));
            Console.Write("Введите a и b для задачи 5.9: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (max, index) = MaxInRange(array, a, b);
            Console.WriteLine($"5.9. Максимальный элемент с {a} по {b}: {max}, его индекс: {index}");
            Console.WriteLine("5.10. Минимальный на четных позициях: " + MinOnChetPos(array));
            Console.Write("Введите a и b для задачи 5.11: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            var (min, minIndex) = MinInRange(array, a, b);
            Console.WriteLine($"5.11. Минимальный элемент с {a} по {b}: {min}, его индекс: {minIndex}");
            Console.WriteLine("5.12. Среднее арифметическое с нечетными индексами: " + NechetIndexAvg(array));
            Console.WriteLine("5.13. Среднее арифметическое элементов не превышающих 50: " + Avg50Less(array));
            var (chetIndexArr, NechetIndexArr) = SplitByIndexRaven(array);
            Console.WriteLine("5.14. Массив с четными индексами: " + string.Join(", ", chetIndexArr));
            Console.WriteLine("5.14. Массив с нечетными индексами: " + string.Join(", ", NechetIndexArr));
            var (chetNechetArr, nechetChetArr) = SplitByValueAndIndexRaven(array);
            Console.WriteLine("5.15. Четные элементы с нечетными индексами: " + string.Join(", ", chetNechetArr));
            Console.WriteLine("5.15. Нечетные элементы с четными индексами: " + string.Join(", ", nechetChetArr));
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        static int sumChetniyIndex(int[] arr) => arr.Where((x, i) => i % 2 == 0).Sum();
        static int MinimalPlus(int[] arr) => arr.Where(x => x > 0).Min();
        static int MaxEl(int[] arr) => arr.Max();
        static int MinEl(int[] arr) => arr.Min();
        static int PlusCount(int[] arr) => arr.Count(x => x > 0);
        static int sumChetPlusIndexab(int[] arr, int a, int b) => arr.Skip(a).Take(b - a + 1).Where((x, i) => x > 0 && x % 2 == 0).Sum();
        static double PlusAvg(int[] arr) => arr.Where(x => x % 2 == 0).Average();
        static int sumChetPlus(int[] arr) => arr.Where(x => x > 0 && x % 2 == 0).Sum();
        static int sumZeroPlusOnChetPos(int[] arr) => arr.Where((x, i) => i % 2 != 0 && x >= 0).Sum();
        static (int max, int index) MaxInRange(int[] arr, int a, int b)
        {
            var subArray = arr.Skip(a).Take(b - a + 1).ToArray();
            int max = subArray.Max();
            int index = Array.IndexOf(subArray, max) + a;
            return (max, index);
        }
        static (int min, int index) MinOnChetPos(int[] arr)
        {
            var evenPos = arr.Where((x, i) => i % 2 == 0).ToArray();
            int min = evenPos.Min();
            int index = Array.IndexOf(arr, min);
            return (min, index);
        }
        static (int min, int index) MinInRange(int[] arr, int a, int b)
        {
            var subArray = arr.Skip(a).Take(b - a + 1).ToArray();
            int min = subArray.Min();
            int index = Array.IndexOf(subArray, min) + a;
            return (min, index);
        }
        static double NechetIndexAvg(int[] arr) => arr.Where((x, i) => i % 2 != 0).Average();
        static double Avg50Less(int[] arr) => arr.Where(x => x <= 50).Average();
        static (int[] chetIndex, int[] nechetIndex) SplitByIndexRaven(int[] arr) =>
            (arr.Where((x, i) => i % 2 == 0).ToArray(), arr.Where((x, i) => i % 2 != 0).ToArray());
        static (int[] chetNechet, int[] nechetChet) SplitByValueAndIndexRaven(int[] arr) =>
            (arr.Where((x, i) => x % 2 == 0 && i % 2 != 0).ToArray(), arr.Where((x, i) => x % 2 != 0 && i % 2 == 0).ToArray());
    
        
    }
}
