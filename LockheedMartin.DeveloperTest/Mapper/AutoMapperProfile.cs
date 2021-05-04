using AutoMapper;
using LockheedMartin.DeveloperTest.BBL.DTO;
using LockheedMartin.DeveloperTest.DAL.Models;

namespace LockheedMartin.DeveloperTest.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ForecastTemperature, TemperatureDto>()
                .ForMember(dest => dest.Day, opt => opt.MapFrom(src => src.DayId))
                .ForMember(dest => dest.WeekId, opt => opt.MapFrom(src => src.ForecastWeekId));

            CreateMap<TemperatureAddDto, ForecastTemperature>()
                .ForMember(dest => dest.DayId, opt => opt.MapFrom(src => src.Day))
                .ForMember(dest => dest.ForecastWeekId, opt => opt.MapFrom(src => src.WeekId));


            CreateMap<TemperatureUpdateDto, ForecastTemperature>();

            CreateMap<ForecastWeek, WeekDto>();
            CreateMap<WeekAddDto, ForecastWeek>();
            CreateMap<WeekUpdateDto, ForecastWeek>();
        }
    }
}
