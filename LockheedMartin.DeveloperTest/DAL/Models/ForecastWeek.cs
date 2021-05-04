using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LockheedMartin.DeveloperTest.DAL.Models
{
    public class ForecastWeek
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
        public virtual List<ForecastTemperature> Temperatures { get; set; }

    }
}
