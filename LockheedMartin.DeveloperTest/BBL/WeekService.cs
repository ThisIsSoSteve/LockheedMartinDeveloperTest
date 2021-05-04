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
    public class WeekService : IWeekService
    {
        private readonly ForecastDbContext _context;
        private readonly IMapper _mapper;
        public WeekService(ForecastDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WeekDto> GetAsync(Guid id)
        {
            var week = await _context.ForecastWeeks.SingleAsync(x => x.Id == id);
            return _mapper.Map<WeekDto>(week);
        }

        public async Task<IEnumerable<WeekDto>> GetAll()
        {
            var weeks = await _context.ForecastWeeks.ToListAsync();
            return _mapper.Map<IEnumerable<WeekDto>>(weeks);
        }

        public async Task<Guid> AddAsync(WeekAddDto week)
        {
            var newWeek = _mapper.Map<ForecastWeek>(week);
            newWeek.Id = Guid.NewGuid();
            await _context.AddAsync(newWeek);

            return newWeek.Id;
        }

        public void Delete(Guid id)
        {
            var weekToDelete = _context.ForecastWeeks.Single(x => x.Id == id);
            _context.Remove(weekToDelete);
        }

        public void Update(WeekUpdateDto week)
        {
            var weekToUpdate = _context.ForecastWeeks.Single(x => x.Id == week.Id);
            _mapper.Map<ForecastWeek>(week);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
