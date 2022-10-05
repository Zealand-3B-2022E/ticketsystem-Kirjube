using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange
            double expectedResult = 240;
            Car car = new Car();
            //act
            double actualResult = car.Price();
            //Assert
            Assert.AreEqual(expectedResult, actualResult); 
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange
            string expectedResult = "Car";
            Car car = new Car();
            //act
            string actualResult = car.VehicleType();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}