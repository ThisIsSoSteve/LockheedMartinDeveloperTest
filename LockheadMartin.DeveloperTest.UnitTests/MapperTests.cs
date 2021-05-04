using AutoMapper;
using LockheedMartin.DeveloperTest.BBL.DTO;
using LockheedMartin.DeveloperTest.DAL.Models;
using LockheedMartin.DeveloperTest.Mapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LockheadMartin.DeveloperTest.UnitTests
{
    [TestClass]
    public class MapperTests
    {
        [TestMethod]
        public void GivenForecastTemperature_WhenMapped_ExpectValidTemperatureDto()
        {
            //Arrange
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            var temperature = new ForecastTemperature { DayId = DayOfWeek.Monday, TemperatureC = 23.0M, Id = Guid.NewGuid(), ForecastWeekId = Guid.NewGuid() };

            //Act
            var mappedTemperature = mapper.Map<TemperatureDto>(temperature);

            //Assert

            Assert.AreEqual(23, mappedTemperature.TemperatureC);
            Assert.AreEqual(DayOfWeek.Monday, mappedTemperature.Day);
            Assert.AreEqual(temperature.Id, mappedTemperature.Id);
            Assert.AreEqual(temperature.ForecastWeekId, mappedTemperature.WeekId);
        }

        [TestMethod]
        public void GivenTemperatureAddDto_WhenMapped_ExpectValidForecastTemperature()
        {
            //Arrange
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            var temperatureAdd = new TemperatureAddDto { Day = DayOfWeek.Monday, TemperatureC = 23.5M, WeekId = Guid.NewGuid() };

            //Act
            var mappedForecastTemperature = mapper.Map<ForecastTemperature>(temperatureAdd);

            //Assert

            Assert.AreEqual(23.5M, mappedForecastTemperature.TemperatureC);
            Assert.AreEqual(DayOfWeek.Monday, mappedForecastTemperature.DayId);
            Assert.AreEqual(temperatureAdd.WeekId, mappedForecastTemperature.ForecastWeekId);
        }
    }
}
