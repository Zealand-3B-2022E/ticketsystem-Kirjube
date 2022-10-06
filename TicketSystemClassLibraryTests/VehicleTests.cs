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
    public class VehicleTests
    {
        [TestMethod()]
        public void CarReturnPriceTest()
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
        public void CarReturnVehicleTypeTest()
        {
            //Arrange
            string expectedResult = "Car";
            Car car = new Car();
            //act
            string actualResult = car.VehicleType();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MCReturnPriceTest()
        {
            //Arrange
            double expectedResult = 125;
            MC mc = new MC();
            //act
            double actualResult = mc.Price();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void MCReturnVehicleTypeTest()
        {
            //Arrange
            string expectedResult = "MC";
            MC mc = new MC();
            //act
            string actualResult = mc.VehicleType();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void MCExpeptionifLicensePlateisOver7()
        {
            
            MC mc = new MC("12345628");

            Assert.Fail();
           
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarExpeptionifLicensePlateisOver7()
        {

            MC mc = new MC("12345628");

            Assert.Fail();

        }
    }
}