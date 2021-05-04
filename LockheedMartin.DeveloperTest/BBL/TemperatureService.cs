using AutoMapper;
using LockheedMartin.DeveloperTest.BBL.DTO;
using LockheedMartin.DeveloperTest.DAL;
using LockheedMartin.DeveloperTest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LockheedMartin.DeveloperTest.BBL
{
    public class TemperatureService : ITemperatureService
    {
        private readonly ForecastDbContext _context;
        private readonly IMapper _mapper;
        public TemperatureService(ForecastDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<TemperatureDto> GetAsync(Guid id)
        {
            var temperature = await _context.ForecastTemperatures.SingleAsync(x => x.Id == id);
            return _mapper.Map<TemperatureDto>(temperature);
        }

        public async Task<IEnumerable<TemperatureDto>> GetAllByWeekIdAsync(Guid weekId)
        {
            var temperatures = await _context.ForecastTemperatures.Where(x => x.ForecastWeekId == weekId).ToListAsync();
            return _mapper.Map<IEnumerable<TemperatureDto>>(temperatures);
        }


        public async Task<IEnumerable<TemperatureDto>> GetAllByWeekIdAndDayIdAsync(Guid weekId, DayOfWeek dayId)
        {
            var temperatures = await _context.ForecastTemperatures.Where(x => x.ForecastWeekId == weekId && x.DayId == dayId).ToListAsync();
            return _mapper.Map<IEnumerable<TemperatureDto>>(temperatures);
        }

        public async Task<Guid> AddAsync(TemperatureAddDto temperature)
        {
            var newTemperature = _mapper.Map<ForecastTemperature>(temperature);
            newTemperature.Id = Guid.NewGuid();
            await _context.AddAsync(newTemperature);

            return newTemperature.Id;
        }

        public void Delete(Guid id)
        {
            var temperatureToDelete = _context.ForecastTemperatures.Single(x => x.Id == id);
            _context.Remove(temperatureToDelete);
        }

        public void Update(TemperatureUpdateDto temperature)
        {
            var temperatureToUpdate = _context.ForecastTemperatures.Single(x => x.Id == temperature.Id);
            _mapper.Map<ForecastTemperature>(temperature);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
