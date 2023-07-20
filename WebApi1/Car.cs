namespace WebApi1
{
    public class Car
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public int powerEngine { get; set; }
        public int yearManufacture { get; set;}

        public Car() { }

        public  Car (string manufacturer, string model, string type, int powerEngine, int year)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.type = type;
            this.powerEngine = powerEngine;
            this.yearManufacture = year;
        }
        public Car(string manufacturer, string model, string type)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.type = type;
            this.powerEngine = 0;
            this.yearManufacture = 0;
        }
    }

}
