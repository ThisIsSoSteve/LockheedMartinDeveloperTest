using LockheedMartin.DeveloperTest.BBL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LockheadMartin.DeveloperTest.UnitTests
{
    [TestClass]
    public class CalculateTests
    {
        [TestMethod]
        [DataRow(new double[] { 10, 8, 10, 8, 8, 4 }, 8)]
        [DataRow(new double[] { 10, 12, 23, 23, 16, 23, -21, -16 }, 8.75)]
        [DataRow(new double[] { 10 }, 10)]
        [DataRow(new double[0], 0)] //empty array
        public void GivenData_WhenCalculatingTheMean_ExpectCorrectAnswer(double[] data, double answer)
        {
            //Arrange
            var datapoints = data;

            //Act
            var mean = Calculate.Mean(datapoints);

            //Assert
            Assert.AreEqual(answer, mean);
        }

        [TestMethod]
        [DataRow(new double[] { 10, 8, 10, 8, 8, 4 }, 4)]
        [DataRow(new double[] { 10, 12, 23, 23, 16, 23, -21, -16 }, 271.4375)]
        [DataRow(new double[] { 10 }, 0)]
        [DataRow(new double[0], 0)] //empty array
        public void GivenData_WhenCalculatingTheVariance_ExpectCorrectAnswer(double[] data, double answer)
        {
            //Arrange
            var datapoints = data;

            //Act
            var variance = Calculate.Variance(datapoints);

            //Assert
            Assert.AreEqual(answer, variance);
        }

        [TestMethod]
        [DataRow(new double[] { 10, 8, 10, 8, 8, 4 }, 2)]
        [DataRow(new double[] { 10, 12, 23, 23, 16, 23, -21, -16 }, 16.475360390595405)]
        [DataRow(new double[] { 10 }, 0)]
        [DataRow(new double[0], 0)] //empty array
        public void GivenData_WhenCalculatingTheStandardDeviation_ExpectCorrectAnswer(double[] data, double answer)
        {
            //Arrange
            var datapoints = data;

            //Act
            var standardDeviation = Calculate.StandardDeviation(datapoints);

            //Assert
            Assert.AreEqual(answer, standardDeviation);
        }

    }
}
