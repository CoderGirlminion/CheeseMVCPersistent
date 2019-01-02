namespace CheeseMVC.Models
{
    public class Cheese
    {
        //initialized by DB Context - creates a unique ID and is a counter for ID
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        //references the category that a specific cheese belongs to within a database
        public int CategoryID { get; set; }

        //references the category within the DBset of Categories
        public CheeseCategory Category { get; set; }
    }
}
