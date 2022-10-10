using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Klasse der beskriver Billet-typen Car hos Oresunds broen. Bruger en reference til TicketSystemClassLibrary
    /// </summary>
    public class OresundCar : Car
    {


        public OresundCar() : base()
        {

        }
        public OresundCar(string licensePlate, DateTime date, bool brobizz)
           : base(licensePlate, date,brobizz)
        {
        }
        /// <summary>
        /// Metode som returnerer standard prisen for en bil. 
        /// </summary>
        /// <returns>double 410</returns>
        public override double Price()
        {
            double price = 410;
            return price;
        }
        /// <summary>
        /// Metode som returnerer vehicleType.
        /// </summary>
        /// <returns>String = "OresundCar"</returns>

        public override string VehicleType()
        {
            string vehicleType = "OresundCar";

            return vehicleType;
        }
        /// <summary>
        /// Metode som tager broBizz og pris og returnerer pris baseret på om kunde har brobizz eller ej. 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="BroBizz"></param>
        /// <returns>double =161;</returns>

        public override double BroBizzDiscount(double price, bool BroBizz)
        {
            if (BroBizz == true)
            {
                return 161;
            }
            else
            {
                return price;
            }
            
        }

      

    }
}
