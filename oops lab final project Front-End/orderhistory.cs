using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oops_lab_final_project_Front_End
{
    public partial class orderhistory : Form
    {
        // 1. This acts as our global database for purchased items!
        public static List<bakraListingCard> PurchasedDatabase = new List<bakraListingCard>();

        public orderhistory()
        {
            InitializeComponent();
        }

        // ... rest of your code

        private void orderhistory_Load(object sender, EventArgs e)
        {
            int currentY = 20; // This will stack your cards neatly!

            // Loop through the data we saved in the database
            foreach (bakraListingCard savedCard in PurchasedDatabase)
            {
                // 1. Create a BRAND NEW visual card every time the window opens 
                bakraListingCard displayCard = new bakraListingCard();

                // 2. Copy the text from the database to the new card
                displayCard.AnimalTitle = savedCard.AnimalTitle;
                displayCard.AnimalPrice = savedCard.AnimalPrice;
                displayCard.AnimalLocation = savedCard.AnimalLocation;
                displayCard.AnimalDetails = savedCard.AnimalDetails;

                // 3. Make it greyed out
                displayCard.MarkAsSold();

                // 4. Position it so they don't overlap
                displayCard.Location = new Point(50, currentY);
                currentY += 160; // Push the next one down

                // 5. Add this FRESH card to the screen!
                this.Controls.Add(displayCard);
            }
        }
    }
    }

