namespace WebApi1
{
    public interface IManagementCars
    {
        public List<Car> GetCarName(string name, List<Car> carsl)
        {
            return carsl.Where(x => (x.model.ToLower() == name.ToLower())||(x.manufacturer.ToLower() == name.ToLower())).ToList(); 
        }
        public List<Car> GetCarEngine(int engine, List<Car> carsl)
        {
            return carsl.Where(x => x.powerEngine == engine).ToList();
        }
        public List<Car> GetCarAge(int age, List<Car> carsl)
        {
            int yearManuf = Convert.ToInt32(DateTime.Now.Year) - age;
            return carsl.Where(x => x.yearManufacture == yearManuf).ToList();
        }
    }
    public class ManagementCars : IManagementCars
    { 
        public ManagementCars() { }
    }
}
