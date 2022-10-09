using Microsoft.AspNetCore.Mvc;
using StoreBaeltTicketLibrary;
using StoreBaeltTicketREST.Managers;

namespace StoreBaeltTicketREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController:ControllerBase
    {
        //Bruger manager
        private ICarManager mgr = new CarManager();

        // GET: api/<ICarController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get()
        {
            List<CarsWeekendDiscount> cars = mgr.Get();
            if (cars == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cars);
            }
        }
        [HttpPost]
        public CarsWeekendDiscount Post([FromBody] CarsWeekendDiscount car)
        {
            return mgr.Create(car);
        }

        [HttpGet]
        [Route("{licensePlate}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByLicensePlate(string licensePlate)
        {
            CarsWeekendDiscount foundCar = mgr.GetByLicensePlate(licensePlate);
            if (foundCar == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(foundCar);
            }

        }
    }
}
