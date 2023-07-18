using Microsoft.AspNetCore.Mvc;
using System;

namespace Pizza.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        List<Pizza> pizzasList = new List<Pizza>
        {   new Pizza ("Philadelphia", 30, 199.00, "Соус аль-фредо, сир моцарелла, лосось, крем-сир" ),
            new Pizza ("Verova", 30, 199.00, "Неаполітанський соус, сир моцарелла, салямі, прошутто, томати, сир ДорБлю, сир пармезан, рукола" ),
            new Pizza ("Margarita",30 ,129, "Неаполітанський соус, сир моцарелла, томати, соус песто" ),
            new Pizza ("Peperoni", 30, 169, "Неаполітанський соус, сир моцарелла, пепероні"),
            new Pizza ("Carbonara", 30, 169, "Соус аль-фредо, сир моцарелла, печериці, бекон, синя цибуля, сир пармезан"),
            new Pizza ("Salyami", 30, 169, "Неаполітанський соус, сир моцарелла, салямі")
        };

        List<PizzaService> pizzaServiceList = new List<PizzaService> { };



        [HttpGet(Name = "PizzaService")]

        public IEnumerable<PizzaService> Get()
        {
          return Enumerable.Range(0, pizzaServiceList.Count).Select(index => new PizzaService 
          {
              pizzasL = pizzaServiceList[index].pizzasL,
              adress = pizzaServiceList[index].adress,
              addInfo = pizzaServiceList[index].addInfo,
              status = pizzaServiceList[index].status
            }).ToArray();

        }
        [HttpPost(Name = "PizzaService")]

        public IEnumerable<PizzaService> Post()
        {
            return Enumerable.Range(0, pizzaServiceList.Count).Select(index => new PizzaService
            {
                pizzasL = pizzaServiceList[index].pizzasL,
                adress = pizzaServiceList[index].adress,
                addInfo = pizzaServiceList[index].addInfo,
                status = pizzaServiceList[index].status
            }).ToArray();

        }
    }
}
