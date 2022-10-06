using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public abstract class Vehicle
    {
        protected string LicensePlate { get; set; }
        protected DateTime Date { get; set; }

        public Vehicle(string licensePlate)
        {
            if (licensePlate.Length > 7)
            {
                throw new ArgumentException("LicensePlate must not be over 7 characters");
            }
            this.LicensePlate = licensePlate;
        }
        public Vehicle():this("Empty")
        {

        }
        public virtual double Price()
        {
            double price = 240;
            return price;
        }


        public virtual string VehicleType()
        {
            string vehicleType = "Vehicle";

            return vehicleType;
        }
      
    }

    
}
