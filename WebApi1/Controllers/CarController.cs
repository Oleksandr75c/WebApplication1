using Microsoft.AspNetCore.Mvc;
using System;

//namespace WebApi1.Controllers
namespace WebApi1
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
       public List<Car> cars = new List<Car>
        {   new Car ( "Volksvagen", "Eos", "cabrio", 211, 2009 ),
            new Car ("Suzuki","GrandVitara","SUV", 149, 2007 ),
            new Car ("Vaz","2101","sedan", 39, 1975 ),
            new Car ("Zaz", "965", "sedan")
        };

        [HttpGet(Name = "GetCars")]
        public IList<Car> Get()
        {

            return Enumerable.Range(0, cars.Count).Select(index => new Car
            {
                manufacturer = cars[index].manufacturer,
                model = cars[index].model,

                type = cars[index].type,
                yearManufacture = cars[index].yearManufacture,
                powerEngine = cars[index].powerEngine
            }).ToList();
        }
    }
}
