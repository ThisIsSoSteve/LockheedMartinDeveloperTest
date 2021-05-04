using System;

namespace LockheedMartin.DeveloperTest.BBL.DTO
{
    public class TemperatureAddDto
    {
        public Guid WeekId { get; set; }
        public DayOfWeek Day { get; set; }
        public decimal TemperatureC { get; set; }
    }
}
