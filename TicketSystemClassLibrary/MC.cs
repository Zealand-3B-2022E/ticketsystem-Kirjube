using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{/// <summary>
/// Klasse med navn MC. Indeholder properties: string LicensePlate og DateTime Date. Samt metoderne Price, og Vehicle Type.
/// </summary>
    public class MC:Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        public MC() : base()
        {

        }
        public MC(string licensePlate)
           : base(licensePlate)
        {
        }
        /// <summary>
        /// Metode som ikke bruger nogle input men returnere en double værdi på 125.
        /// </summary>
        /// <returns>Double price = 125</returns>
        public override double Price()
        {
            double price = 125;
            return price;
        }
        /// <summary>
        /// Metode som ikke bruger nogle input og returnere en string "MC"
        /// </summary>
        /// <returns>string vehicleType = "MC"</returns>
        public override string VehicleType()
        {
            string vehicleType = "MC";

            return vehicleType;
        }

    }
}
