using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Program3
    {
        static void Main()
        {
            double[] purchase = new double[] { 10, 20, 5, 15, 50 };

            DiscountOperation currentDiscount = DiscountCheapestItemFree;

            Console.WriteLine("Discount = {0}", currentDiscount(purchase));

        }

        delegate double DiscountOperation(double[] amounts);

        static double Discount20Pct(double[] amounts)
        {
            double sum = 0;
            for (int i = 0; i < amounts.Length; i++)
            {
                sum = sum + amounts[i];
            }
            return 0.2 * sum;
        }

        static double DiscountCheapestItemFree(double[] amounts)
        {
            double min = amounts[0];
            for (int i = 1; i < amounts.Length; i++)
            {
                if (amounts[i] < min)
                {
                    min = amounts[i];
                }
            }
            return min;
        }


    }
}
