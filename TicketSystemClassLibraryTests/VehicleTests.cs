using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBaeltTicketLibrary;

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
            
            MC mc = new MC("12345628", DateTime.Now);

            Assert.Fail();
           
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CarExpeptionifLicensePlateisOver7()
        {

            MC mc = new MC("12345628", DateTime.Now);

            Assert.Fail();

        }

        [TestMethod()]
        public void MCDiscount5ProcentTest()
        {
            ///Arrange
            MC mc = new MC();
            double price = mc.Price();
            bool brobizz = true;
            double expectedValue = 118.75;
            //act
            double actuallyValue = mc.BroBizzDiscount(price, brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue,0.1);

        }

        [TestMethod()]
        public void CarDiscount5ProcentTest()
        {
            ///Arrange
            Car car = new Car();
            double price = car.Price();
            bool brobizz = true;
            double expectedValue = 228;
            //act
            double actuallyValue = car.BroBizzDiscount(price, brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);
          


        }
        /*---------------------------------------------------------------------------*/
        [TestMethod()]
        public void StorebaeltDiscountWeekendBroBizzTest()
        {
            ///Arrange
             CarsWeekendDiscount car = new CarsWeekendDiscount();
            double price = car.Price();
            bool brobizz = true;
            double expectedValue = 182.4;
            //act
            double actuallyValue = car.weekendDiscount(brobizz,DateTime.Today);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);



        }


        
        [TestMethod()]
        public void StorebaeltDiscountWeekendIkkeBroBizzTest()
        {
        ///Arrange
            
            CarsWeekendDiscount car = new CarsWeekendDiscount();
            double price = car.Price();
            bool brobizz = false;
            double expectedValue = 192;
           
            //act
            double actuallyValue = car.weekendDiscount(brobizz, DateTime.Now);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);



        }
    [TestMethod()]
    public void StorebaeltDiscountIkkeWeekendBroBizzTest()
    {
        ///Arrange
        CarsWeekendDiscount car = new CarsWeekendDiscount();
        double price = car.Price();
        bool brobizz = true;
        double expectedValue = 228;
        //act
        double actuallyValue = car.weekendDiscount(brobizz, DateTime.Today.AddDays(2));
        //Assert
        Assert.AreEqual(expectedValue, actuallyValue, 0.1);

    }
     [TestMethod()]
    public void StorebaeltDiscountIkkeWeekendIkkeBroBizzTest()
    {
        ///Arrange
        CarsWeekendDiscount car = new CarsWeekendDiscount();
        double price = car.Price();
        bool brobizz = false;
        double expectedValue = 240;
        //act
        double actuallyValue = car.weekendDiscount(brobizz, DateTime.Today.AddDays(2));
        //Assert
        Assert.AreEqual(expectedValue, actuallyValue, 0.1);

    }

}
}