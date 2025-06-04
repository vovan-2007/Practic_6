namespace lab6t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[15];
            Random rnd = new Random();
            for (int i = 0; i < prices.Length; i++)
            {
                prices[i] = rnd.Next(20, 301);
            }
            Console.WriteLine("Цены: " + string.Join(", ", prices));
            int minPrice = prices.Min();
            int index = Array.IndexOf(prices, minPrice);
            Console.WriteLine($"Самый дешевый товар: цена {minPrice}, порядковый номер {index}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
