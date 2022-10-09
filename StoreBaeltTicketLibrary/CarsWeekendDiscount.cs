using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class CarsWeekendDiscount:Car
    {
        public CarsWeekendDiscount() : base()
        {

        }
        public CarsWeekendDiscount(string licensePlate, DateTime date)
           : base(licensePlate, date)
        {
        }

        public double weekendDiscount(bool brobizz, DateTime date)
        {
            double price = Price();
            double newPrice = price;
            int weekDay = (int)date.DayOfWeek;
            if( weekDay == 6 || weekDay == 0)
            {
                
                 newPrice = price * 0.8;
            }
             
            if(brobizz == true)
            {
                newPrice = BroBizzDiscount(newPrice, true);
            }

            return newPrice;
        }
    }
}
