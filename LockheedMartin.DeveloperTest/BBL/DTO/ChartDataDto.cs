using System;
using System.Collections.Generic;
namespace LockheedMartin.DeveloperTest.BBL.DTO
{
    public class ChartDataDto
    {
        public DataPlotDto DataPlots { get; set; }
        public DataPlotDto Mean { get; set; }
        public double StandardDeviation { get; set; }
    }
}
