using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBaeltTicketLibrary;
using OresundTicketLibrary;
using System.Runtime.ConstrainedExecution;

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
            
            MC mc = new MC("12345628", DateTime.Now, false);

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
            car.broBizz = true;
            DateTime date = new DateTime(2022, 10, 9);
            double expectedValue = 182.4;
            //act
            double actuallyValue = car.weekendDiscount(car.broBizz,date);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);



        }


        
        [TestMethod()]
        public void StorebaeltDiscountWeekendIkkeBroBizzTest()
        {
        ///Arrange
            
            CarsWeekendDiscount car = new CarsWeekendDiscount();
            double price = car.Price();  
            double expectedValue = 192;
            car.broBizz = false;
            DateTime date = new DateTime(2022, 10, 9);

            //act
            double actuallyValue = car.weekendDiscount(car.broBizz, date);
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
        /*---------------------------------------------------------------------------*/

        [TestMethod()]
        public void OresundStandardPrisBilTest()
        {
            ///Arrange
            OresundCar car = new OresundCar();
            double expectedValue = 410;
            //act
            double actuallyValue = car.Price();
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }

        [TestMethod()]
        public void OresundStandardPrisMCTest()
        {
            ///Arrange
            OresundMC mc = new OresundMC();
            double expectedValue = 210;
            //act
            double actuallyValue = mc.Price();
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }
        [TestMethod()]
        public void OresundfalseBrobizzPrisBilTest()
        {
            ///Arrange
            OresundCar car = new OresundCar();
            double expectedValue = 410;
            bool brobizz = false;
            double price = car.Price();
            //act
            double actuallyValue = car.BroBizzDiscount(price,brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }
        [TestMethod()]
        public void OresundtrueBrobizzPrisBilTest()
        {
            ///Arrange
            OresundCar car = new OresundCar();
            double expectedValue = 161;
            bool brobizz = true;
            double price = car.Price();
            //act
            double actuallyValue = car.BroBizzDiscount(price, brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }
        [TestMethod()]
        public void OresundfalseBrobizzPrisMCTest()
        {
            ///Arrange
            OresundMC mc = new OresundMC();
            double expectedValue = 210;
            bool brobizz = false;
            double price = mc.Price();
            //act
            double actuallyValue = mc.BroBizzDiscount(price, brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }
        [TestMethod()]
        public void OresundtrueBrobizzPrisMCTest()
        {
            ///Arrange
            OresundMC mc = new OresundMC();
            double expectedValue = 73;
            bool brobizz = true;
            double price = mc.Price();
            //act
            double actuallyValue = mc.BroBizzDiscount(price, brobizz);
            //Assert
            Assert.AreEqual(expectedValue, actuallyValue, 0.1);

        }

    }
}