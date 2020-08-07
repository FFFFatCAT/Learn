using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fatigue.RainFlow;

namespace RainFlowCount
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { -2, 1, -3, 5, -1, 3, -4, 4, -2 };
            CycleCount[] res = RainFlow_Counting(data);
            Console.WriteLine("RainFlow counting method");
            Console.WriteLine("      Mean:  Amplitude:  Count:");
            for (int i = res.GetLowerBound(0); i <= res.GetUpperBound(0); i++)
            {
                Console.WriteLine(" {0,10:g5}  {1,10:g5}  {2,6}", res[i].Mean, res[i].Amplitude, res[i].Count);
            }

            res = RainFlow_Simplified(data);
            Console.WriteLine("RainFlow simplified counting method");
            Console.WriteLine(PrintCycleCounts(res));

            res = RangePair_Counting(data);
            Console.WriteLine("Range pair counting method");
            Console.WriteLine(PrintCycleCounts(res));
        }
    }
}
