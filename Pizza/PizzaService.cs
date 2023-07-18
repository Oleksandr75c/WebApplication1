using System.Security.Cryptography.Xml;

namespace Pizza
{
    public class PizzaService
    {
        public List<Pizza> pizzasL {  get; set; }
        public string adress { get; set; }
        public string addInfo    { get; set;}
        public string status { get; set; }

        public PizzaService() { }

        public PizzaService(List<Pizza> pizzasL, string adress, string addInfo)     // constructor - CREATE
        {
            this.pizzasL = pizzasL;
            this.adress = adress;
            this.addInfo = addInfo;
            this.status = "created";
        }

        public string readOrder(out  List<Pizza> pizzasL, out string adress, out string addInf) // READ order
        {
            pizzasL = this.pizzasL;
            adress = this.adress;
            addInf = this.addInfo;
            return this.status;
        }

        public void updateOrderAdress(string newAdress, string newInfo )    //UPDATE order
        { 
            this.adress = newAdress;
            this.addInfo = newInfo;
            this.status = "changed";
        }

        public void addPizza(List<Pizza> addPizzasl) //UPDATE order
        { 
            foreach (Pizza pizza in addPizzasl)  this.pizzasL.Add(pizza);
            this.status = "changed";
        }
        public void delPizza(List<Pizza> delPizzasl) //UPDATE order
        {
            foreach (Pizza pizza in delPizzasl) this.pizzasL.Remove(pizza);
            this.status = "changed";
        }
        public void deleteOrder(string reason)      //DELETE order
        { 
            this.status = "deleted";
            this.addInfo += $" Order DELETE. Reason - {reason}.";
        }
        public void finishOrder()
        { this.status = "fanished"; }
    }

}
