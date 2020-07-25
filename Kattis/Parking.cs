using System;

namespace Kattis.Problem1
{
    public static class Parking
    {
        public static void CalculateParking()
        {
            string number;

            while ((number = Console.ReadLine()) != null)
            {
                var n = int.Parse(number);
                long low = 100;
                long high = 0;
                for (int i = 0; i < n; i++)
                {
                    var numberStores = int.Parse(Console.ReadLine());
                    var positions = Console.ReadLine();
                    string[] split = positions.Split(new char[] { ' ' }, StringSplitOptions.None);
                    for (int j = 0; j < numberStores; j++)
                    {
                        var position = int.Parse(split[j]);
                        if (position < low)
                        {
                            low = position;
                        }
                        if (position > high)
                        {
                            high = position;
                        }
                    }
                    Console.WriteLine(2 * (high - low));
                    low = 100;
                    high = 0;
                }
            }
        }
        public static void CalculateParking2()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var numberStores = int.Parse(Console.ReadLine());
                var positions = Console.ReadLine();
                var split = positions.Split(new char[] { ' ' }, StringSplitOptions.None).Select(a => int.Parse(a));
                var max = split.Max();
                var min = split.Min();

                Console.WriteLine(2 * (max - min));
            }
        }
    }
}
