namespace Carpet_Cleaning_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smallCarpet = 25;
            int largeCarpet = 35;
            double taxRate = 0.06;

            Console.Write("Number of small carpets:");
            int smallQuantity = int.Parse(Console.ReadLine());

            Console.Write("Number of large carpets:");
            int largeQuantity = int.Parse(Console.ReadLine());

            if(smallQuantity < 0 || largeQuantity < 0 )
              Console.WriteLine("Invalid input...Can't input negative values.");

            else
            {
                int cost = (smallCarpet * smallQuantity) + (largeCarpet * largeQuantity);
                double netCost = (cost * taxRate) + cost;
                
                Console.WriteLine($"Total estimate: {netCost}");
                Console.WriteLine("This estimate is valid for 30 days.");
            }

        }
    }
}
