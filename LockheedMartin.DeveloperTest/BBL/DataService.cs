using AutoMapper;
using LockheedMartin.DeveloperTest.BBL.DTO;
using LockheedMartin.DeveloperTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.BBL
{
    public class DataService : IDataService
    {
        public ChartDataDto GetDataForChart(IEnumerable<TemperatureDto> temperatures, DayOfWeek day)
        {
            var temperturesOnly = ConvertTemperatureDtosToDoubleArray(temperatures);

            var chartData = new ChartDataDto
            {
                DataPlots = new DataPlotDto
                {
                    Name = day.ToString(),
                    Color = "rgba(223, 83, 83, .5)",
                    Data = ConvertTemperatureDtosToMultiDoubleArray(temperatures)
                },
                Mean = new DataPlotDto
                {
                    Name = $"{day} Mean",
                    Color = "rgba(119, 152, 191, 1)",
                    Data = new double[1][] { new double[] { (double)day, Calculate.Mean(temperturesOnly) } }
                },
                StandardDeviation = Calculate.StandardDeviation(temperturesOnly)
            };

            return chartData;
        }

        public double[][] ConvertTemperatureDtosToMultiDoubleArray(IEnumerable<TemperatureDto> temperatures)
        {
            var temperaturesArray = temperatures.ToArray();
            var data = new double[temperaturesArray.Length][];

            for (int i = 0; i < temperaturesArray.Length; i++)
            {
                data[i] = new double[2];
                data[i][0] = (double)temperaturesArray[i].Day;
                data[i][1] = (double)temperaturesArray[i].TemperatureC;
            }

            return data;
        }

        public double[] ConvertTemperatureDtosToDoubleArray(IEnumerable<TemperatureDto> temperatures)
        {
            return temperatures.Select(x => (double)x.TemperatureC).ToArray();
        }
    }
}
