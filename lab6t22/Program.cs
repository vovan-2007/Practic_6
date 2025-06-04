namespace lab6t22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void BubbleSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                        }
                    }
                }
            }
            static void SelectionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    int minIndex = i;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] < arr[minIndex])
                        {
                            minIndex = j;
                        }
                    }
                    (arr[i], arr[minIndex]) = (arr[minIndex], arr[i]);
                }
            }
            static void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivot = Part(arr, left, right);
                    QuickSort(arr, left, pivot - 1);
                    QuickSort(arr, pivot + 1, right);
                }
            }
            static int Part(int[] arr, int left, int right)
            {
                int pivot = arr[right];
                int i = left - 1;

                for (int j = left; j < right; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                    }
                }
                (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
                return i + 1;
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
                int[] bubbleSorted = (int[])array.Clone();
                BubbleSort(bubbleSorted);
                Console.WriteLine("22.1. Сортировка пузырьком: " + string.Join(", ", bubbleSorted));
                int[] selectionSorted = (int[])array.Clone();
                SelectionSort(selectionSorted);
                Console.WriteLine("22.2. Сортировка выбором: " + string.Join(", ", selectionSorted));
                int[] quickSorted = (int[])array.Clone();
                QuickSort(quickSorted, 0, quickSorted.Length - 1);
                Console.WriteLine("22.3. Быстрая сортировка: " + string.Join(", ", quickSorted));
            }
    }
}
