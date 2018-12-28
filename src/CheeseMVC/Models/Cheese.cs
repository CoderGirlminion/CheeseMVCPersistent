namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public CheeseType Type { get; set; }

        //initialized by DB Context - creates a unique ID and is a counter for ID
        public int ID { get; set; }
    }
}
