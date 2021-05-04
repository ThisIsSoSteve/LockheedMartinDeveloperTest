
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LockheedMartin.DeveloperTest.DAL.Models
{
    public class ForecastTemperature
    {
        public Guid Id { get; set; }
        public DayOfWeek DayId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TemperatureC { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public Guid ForecastWeekId { get; set; }
        public virtual ForecastWeek ForecastWeek { get; set; }
    }
}
