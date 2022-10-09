using StoreBaeltTicketLibrary;

namespace StoreBaeltTicketREST.Managers
{
    public interface ICarManager
    {
        List<CarsWeekendDiscount> Get();
        CarsWeekendDiscount Create(CarsWeekendDiscount car);
    }
}
