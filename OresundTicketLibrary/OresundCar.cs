using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundTicketLibrary
{
    public class OresundCar : Car
    {


        public OresundCar() : base()
        {

        }
        public OresundCar(string licensePlate, DateTime date)
           : base(licensePlate, date)
        {
        }
        public override double Price()
        {
            double price = 410;
            return price;
        }

        public override string VehicleType()
        {
            string vehicleType = "OresundCar";

            return vehicleType;
        }

        public override double BroBizzDiscount(double price, bool BroBizz)
        {
            return 161;
        }

      

    }
}
