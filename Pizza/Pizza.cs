namespace Pizza
{
    public class Pizza
    {
        public string name { get; set; }
        public string description { get; set; }
        public int size { get; set; }
        public double price { get; set; }

        public Pizza(string name, int size, double price)
        { 
            this.name = name; 
            this.size = size;
            this.price = price;
        }
        public Pizza(string name, int size, double price, string description)
        { 
            this.name = name;
            this.size = size;
            this.price = price;
            this.description = description;
        }
    }
}
