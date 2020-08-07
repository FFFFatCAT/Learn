using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using static Fatigue.RainFlow;

namespace DataFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            double[] data = { 0, 1, 2, 3, -4, 8, 93, 1, 4, 4 };
            double[] data2 = new double[200];
            Random ra = new Random();
            for (int i = 0; i < data2.Length; i++)
            {
                data2[i] = ra.Next(1, 10);
            }

            sw.Start();
            double[] data_cv = MyCounting.FindPeakValley(data2);
            CycleCount[] res = RainFlow_Counting(data2);
            //foreach (var i in data_cv)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(data_cv.Length);
            sw.Stop();
            TimeSpan ts2 = sw.Elapsed;
            Console.WriteLine("Stopwatch总共花费{0}ms.", ts2.TotalMilliseconds);

            //CycleCount[] res = RainFlow_Counting(data);
            //Console.WriteLine("RainFlow counting method");
            //Console.WriteLine("      Mean:  Amplitude:  Count:");
            //for (int i = res.GetLowerBound(0); i <= res.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine(" {0,10:g5}  {1,10:g5}  {2,6}", res[i].Mean, res[i].Amplitude, res[i].Count);
            //}

            //res = RainFlow_Simplified(data);
            //Console.WriteLine("RainFlow simplified counting method");
            //Console.WriteLine(PrintCycleCounts(res));

            //res = RangePair_Counting(data);
            //Console.WriteLine("Range pair counting method");
            //Console.WriteLine(PrintCycleCounts(res));
            Console.ReadLine();
        }
    }
    class MyCounting
    {
        /// <summary>
        /// 时序数据处理，只提取波峰波谷值，同时保留起止点。
        /// <paramref name="TimeSeriesData"/> 
        /// 待处理时序数据
        /// </summary>
        /// <param name="TimeSeriesData"></param>
        /// <returns></returns>
        public static double[] FindPeakValley(double[] TimeSeriesData)
        {
            List<double> PeakValley = new List<double>
            {
                TimeSeriesData[0]
            };

            for (int i = 1; i < TimeSeriesData.Length - 1; i++)
            {
                if ((TimeSeriesData[i] >= TimeSeriesData[i - 1] && TimeSeriesData[i] > TimeSeriesData[i + 1]) || (TimeSeriesData[i] <= TimeSeriesData[i - 1] && TimeSeriesData[i] < TimeSeriesData[i + 1]))
                {
                    PeakValley.Add(TimeSeriesData[i]);
                }
            }
            if (TimeSeriesData.Last() != PeakValley.Last())
            {
                PeakValley.Add(TimeSeriesData.Last());
            }
            return PeakValley.ToArray();
        }

    }
}
