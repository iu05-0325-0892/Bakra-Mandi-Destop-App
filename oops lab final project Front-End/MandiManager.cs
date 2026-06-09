using System;
using System.Collections.Generic;

namespace oops_lab_final_project_Front_End
{
    public class MandiManager
    {
        // List jo saare bakron ka data temporary save rakhegi
        private List<Goat> allGoats = new List<Goat>();

        // 1. Mandi me naya jaanwar register karne ka function
        public void AddGoat(Goat g)
        {
            allGoats.Add(g);
        }

        // 2. Jo bakray bikhay nahi hain, unki list nikalne ke liye
        public List<Goat> GetAvailableGoats()
        {
            return allGoats.FindAll(g => g.IsSold == false);
        }

        // 3. Bakra sell karne ke liye
        public bool SellGoat(string id)
        {
            Goat g = allGoats.Find(x => x.Id == id);
            if (g != null && !g.IsSold)
            {
                g.IsSold = true;
                return true; // Sell ho gaya
            }
            return false; // Nahi mila ya pehle se sold tha
        }
    }
}