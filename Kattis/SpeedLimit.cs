using System;

namespace Kattis.Problem1
{
    public static class SpeedLimit
    {
        public static void CalculateSpeedLimit()
        {
            string number;
            long sum = 0;
            long total = 0;
            while ((number = Console.ReadLine()) != null)
            {
                var n = Int64.Parse(number);
                if (n > 0)
                {
                    string line;
                    for (int i = 0; i < n; i++)
                    {
                        line = Console.ReadLine();
                        string[] split = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                        long a = Int64.Parse(split[0]);
                        long b = Int64.Parse(split[1]);
                        if (b > 0)
                        {
                            total = total + (a * (b - sum));
                            sum = b;
                        }
                    }
                    Console.WriteLine($"{total} miles");
                    sum = 0;
                    total = 0;
                }
            }
        }
    }
}
