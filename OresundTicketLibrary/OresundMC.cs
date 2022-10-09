using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundTicketLibrary
{
    public class OresundMC:MC
    {
        public OresundMC() : base()
        {

        }
        public OresundMC(string licensePlate, DateTime date)
           : base(licensePlate, date)
        {
        }
        /// <summary>
        /// Metode som ikke bruger nogle input men returnere en double værdi på 125.
        /// </summary>
        /// <returns>Double price = 125</returns>
        public override double Price()
        {
            double price = 210;
            return price;
        }
        /// <summary>
        /// Metode som ikke bruger nogle input og returnere en string "MC"
        /// </summary>
        /// <returns>string vehicleType = "MC"</returns>
        public override string VehicleType()
        {
            string vehicleType = "OresundMC";

            return vehicleType;
        }

        public override double BroBizzDiscount(double price, bool BroBizz)
        {
            return 73;
        }
    }
}
