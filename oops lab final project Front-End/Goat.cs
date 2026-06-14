using System;

namespace oops_lab_final_project_Front_End
{
    // Base Class: Isme saari common cheezein hain (Encapsulation)
    public class Goat
    {
        public string Id { get; set; }
        public string Breed { get; set; }  // Kamori, Beetal, Rajanpuri, Teddy
        public double Weight { get; set; } // KG me
        public decimal Price { get; set; }
        public bool IsSold { get; set; }

        // Constructor: Naya bakra system me add karte waqt use hoga
        public Goat(string id, string breed, double weight, decimal price)
        {
            Id = id;
            Breed = breed;
            Weight = weight;
            Price = price;
            IsSold = false;
        }

        // Polymorphism: Isko hum child classes me badal sakte hain
        public virtual string GetDetails()
        {
            return $"ID: {Id} | Breed: {Breed} | Wt: {Weight}kg | Price: Rs. {Price}";
        }
    }
}