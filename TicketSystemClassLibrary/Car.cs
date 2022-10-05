﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// En klasse med navnet Car, som har propetierne: LicensePlate, Date og metoderne: VehicleType og Price.
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Metode som ikke bruger nogle input men returnere en double værdi på 240.
        /// </summary>
        /// <returns>Double price = 240</returns>
        public double Price()
        {
            double price = 240;
            return price;
        }
        /// <summary>
        /// Metode som ikke bruger nogle input og returnere en string "Car"
        /// </summary>
        /// <returns>string vehicleType = "Car"</returns>
        public string VehicleType()
        {
            string vehicleType = "Car";

            return vehicleType;
        }
    }
}