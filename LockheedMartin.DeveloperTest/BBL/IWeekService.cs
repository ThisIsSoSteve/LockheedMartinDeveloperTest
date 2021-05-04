using LockheedMartin.DeveloperTest.BBL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.BBL
{
    public interface IWeekService
    {
        Task<Guid> AddAsync(WeekAddDto week);
        void Delete(Guid id);
        Task<IEnumerable<WeekDto>> GetAll();
        Task<WeekDto> GetAsync(Guid id);
        Task<int> SaveAsync();
        void Update(WeekUpdateDto week);
    }
}