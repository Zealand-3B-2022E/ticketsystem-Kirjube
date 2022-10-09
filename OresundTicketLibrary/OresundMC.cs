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
        /// <returns>Double price = 210</returns>
        public override double Price()
        {
            double price = 210;
            return price;
        }
        /// <summary>
        /// Metode som ikke bruger nogle input og returnere en string "OresundMC"
        /// </summary>
        /// <returns>string vehicleType = "OresundMC"</returns>
        public override string VehicleType()
        {
            string vehicleType = "OresundMC";

            return vehicleType;
        }
        /// <summary>
        /// Metode som tager double pris og bool brobizz og returnerer en ny pris baseret på om kunde har brobizz eller ej. 
        /// </summary>
        /// <param name="price"></param>
        /// <param name="BroBizz"></param>
        /// <returns>double = 73 hvis brobizz er true, 210 hvis brobizz er false. </returns>
        public override double BroBizzDiscount(double price, bool BroBizz)
        {
            if(BroBizz == true)
            {
                return 73;

            }
            else
            {
                return price;
            }
            
        }
    }
}
