using LockheedMartin.DeveloperTest.BBL;
using LockheedMartin.DeveloperTest.BBL.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LockheadMartin.DeveloperTest.UnitTests
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GivenTemperatureData_WhenProccessed_ExpectCorrectAnswers()
        {
            //Arrange
            var temperatures = new List<TemperatureDto>()
            {
                new TemperatureDto
                {
                    Day = DayOfWeek.Monday,
                    TemperatureC = 23.1M,
                },
                new TemperatureDto
                {
                    Day = DayOfWeek.Monday,
                    TemperatureC = 11.1M,
                },
                new TemperatureDto
                {
                    Day = DayOfWeek.Monday,
                    TemperatureC = -0.1M,
                }
            };

            //Act
            var dataService = new DataService();
            var chartData = dataService.GetDataForChart(temperatures, DayOfWeek.Monday);

            //Assert
            Assert.AreEqual(DayOfWeek.Monday.ToString(), chartData.DataPlots.Name);
            Assert.AreEqual(3, chartData.DataPlots.Data.Length);
            Assert.AreEqual(1, chartData.Mean.Data.Length);
            Assert.AreNotEqual(0, chartData.StandardDeviation);
        }
    }
}
