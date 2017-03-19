using System;
using System.Collections.Generic;

namespace SalesReport
{
    public class SalesReport
    {
        public static void Main()
        {
            var total = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < total; i++)
            {
                var currSaleAsString = Console.ReadLine();
                var currSale = Sale.Parse(currSaleAsString);

                if (!result.ContainsKey(currSale.Town))
                {
                    result[currSale.Town] = 0;
                }

                result[currSale.Town] += currSale.Quantity * currSale.Price;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}
