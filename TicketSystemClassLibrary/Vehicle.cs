using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Abstract Class used for Vehicles. 
    /// </summary>
    public abstract class Vehicle
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Constructor. For the Default Discount is set to "empty"
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <exception cref="ArgumentException"></exception>

        public Vehicle(string licensePlate, DateTime date)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("LicensePlate must not be over 7 characters");
            }
            this.LicensePlate = licensePlate;

            Date = date;
        }
        public Vehicle():this("Empty",DateTime.Now)
        {

        }
        /// <summary>
        /// Method which returns price of Vehicle. Virtual so it can be overrided
        /// </summary>
        /// <returns> 0 kr</returns>
        public virtual double Price()
        {
            double price = 0;
            return price;
        }
        /// <summary>
        /// Method which returns discounted price. Based on Inputs: double Price and bool Brobizz
        /// </summary>
        /// <returns> discounted price kr</returns>
        public virtual double BroBizzDiscount(double price, bool BroBizz)
        {
            double broBizzDiscount = 5;
            double discountedPrize;
           if(BroBizz == true)
            {
                discountedPrize = price - price / 100 * broBizzDiscount;
            }
            else
            {
                discountedPrize = price;
            }
            return discountedPrize;

        }
        /// <summary>
        /// Method Which returns vehicleType. The Method is Virtual so it can be overrided
        /// </summary>
        /// <returns>"Vehicle"</returns>

        public virtual string VehicleType()
        {
            string vehicleType = "Vehicle";

            return vehicleType;
        }
      
    }

    
}
