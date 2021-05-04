using System;
using System.Linq;

namespace LockheedMartin.DeveloperTest.BBL
{
    public static class Calculate
    {
        public static double Mean(double[] dataPoints)
        {
            if (dataPoints.Length == 0)
            {
                return 0;
            }

            return dataPoints.Sum() / dataPoints.Length;
        }

        public static double Variance(double[] dataPoints)
        {
            if (dataPoints.Length == 0)
            {
                return dataPoints.Sum();
            }

            var mean = Mean(dataPoints);
            for (int i = 0; i < dataPoints.Length; i++)
            {
                dataPoints[i] = Math.Pow(dataPoints[i] - mean, 2);
            }

            return dataPoints.Sum() / dataPoints.Length;
        }

        public static double StandardDeviation(double[] dataPoints)
        {
            var variance = Variance(dataPoints);
            return Math.Sqrt(variance);
        }
    }
}
