using System;

namespace LockheedMartin.DeveloperTest.BBL.DTO
{
    public class TemperatureDto
    {
        public Guid Id { get; set; }
        public DayOfWeek Day { get; set; }
        public decimal TemperatureC { get; set; }
        public Guid WeekId { get; set; }
    }
}
