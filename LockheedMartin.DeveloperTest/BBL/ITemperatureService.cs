using LockheedMartin.DeveloperTest.BBL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.BBL
{
    public interface ITemperatureService
    {
        Task<Guid> AddAsync(TemperatureAddDto temperature);
        void Delete(Guid id);
        Task<IEnumerable<TemperatureDto>> GetAllByWeekIdAsync(Guid weekId);
        Task<IEnumerable<TemperatureDto>> GetAllByWeekIdAndDayIdAsync(Guid weekId, DayOfWeek dayId);
        Task<TemperatureDto> GetAsync(Guid id);
        Task<int> SaveAsync();
        void Update(TemperatureUpdateDto temperature);
    }
}