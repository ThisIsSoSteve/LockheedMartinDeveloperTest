using LockheedMartin.DeveloperTest.BBL.DTO;
using System;
using System.Collections.Generic;

namespace LockheedMartin.DeveloperTest.BBL
{
    public interface IDataService
    {
        ChartDataDto GetDataForChart(IEnumerable<TemperatureDto> temperatures, DayOfWeek day);
    }
}