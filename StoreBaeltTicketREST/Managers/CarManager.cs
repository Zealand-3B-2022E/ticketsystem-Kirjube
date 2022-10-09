using StoreBaeltTicketLibrary;
using static System.Reflection.Metadata.BlobBuilder;

namespace StoreBaeltTicketREST.Managers
{
    public class CarManager:ICarManager
    {
        private static List<CarsWeekendDiscount> _cars = new List<CarsWeekendDiscount>() { new CarsWeekendDiscount {Date = DateTime.Now, LicensePlate = "1234567", broBizz = true}, new CarsWeekendDiscount {Date = DateTime.Now.AddDays(1), LicensePlate = "2345678", broBizz = true},new CarsWeekendDiscount {Date = DateTime.Now, LicensePlate = "3456789", broBizz = false}
        };

        public CarsWeekendDiscount Create(CarsWeekendDiscount car)
        {
            _cars.Add(car);
            return car;
        }

        public List<CarsWeekendDiscount> Get()
        {
            return _cars;
        }
    }
}
