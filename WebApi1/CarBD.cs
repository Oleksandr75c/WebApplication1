namespace WebApi1
{
    public class CarBD
    {
        public  List<Car> cars;

    public  CarBD()
        {
            cars = new List<Car>
            {   new Car ("Volksvagen", "Eos", "cabrio", 211, 2009 ),
                new Car ("Suzuki","GrandVitara","SUV", 149, 2007 ),
                new Car ("Vaz","2101","sedan", 39, 1975 ),
                new Car ("Zaz", "965", "sedan"),
                new Car ("Volksvagen", "bits", "cabrio", 155, 2015 ),
                new Car ("Suzuki","GrandVitara","SUV", 149, 2015)
            };
        }
    }
}
