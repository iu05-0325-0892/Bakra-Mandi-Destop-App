using System;
using System.Drawing;
using System.Windows.Forms;

namespace oops_lab_final_project_Front_End
{
    public partial class marketplacesidepanel : Form
    {
        // Counter for the newly added animals
        int animalCounter = 1;

        public marketplacesidepanel()
        {
            InitializeComponent();
        }

        private void marketplacesidepanel_Load(object sender, EventArgs e)
        {
            // 1. Turn on scrolling in case the cards go past the bottom of the screen
            this.AutoScroll = true;

            // 2. Create arrays of sample data
            string[] titles = { "Beautiful White Bakra", "Spotted Brown Goat", "Pure Gulabi Bakra", "Heavy Kamori Goat", "Desi Black Bakra" };
            string[] prices = { "PKR 50,000", "PKR 45,000", "PKR 85,000", "PKR 120,000", "PKR 40,000" };
            string[] locations = { "Karachi", "Lahore", "Islamabad", "Multan", "Faisalabad" };
            string[] details = { "2 Teeth | 40 kg", "4 Teeth | 50 kg", "2 Teeth | 35 kg", "6 Teeth | 70 kg", "2 Teeth | 38 kg" };

            int verticalSpacing = 20; // Starting position for the first card

            // 3. Loop to spawn all 5 animals
            for (int i = 0; i < 5; i++)
            {
                bakraListingCard newAnimalCard = new bakraListingCard();

                // Inject data
                newAnimalCard.AnimalTitle = titles[i];
                newAnimalCard.AnimalPrice = prices[i];
                newAnimalCard.AnimalLocation = locations[i];
                newAnimalCard.AnimalDetails = details[i];

                // Position the card so they stack cleanly
                newAnimalCard.Location = new Point(50, verticalSpacing);
                verticalSpacing += 160; // Pushes the next card 160 pixels down

                // Force it onto the screen
                this.Controls.Add(newAnimalCard);
            }
        }

        // --- NEWLY ADDED BUTTON FUNCTIONS BELOW ---

        private void btnadd_Click(object sender, EventArgs e)
        {
            int nextY = 20; // Default starting position if the screen is empty

            // Find the lowest card currently on the screen so we don't overlap
            foreach (Control c in this.Controls)
            {
                if (c is bakraListingCard)
                {
                    if (c.Location.Y >= nextY)
                    {
                        nextY = c.Location.Y + 160; // Match the 160 spacing from your Load method
                    }
                }
            }

            // Build the new card
            bakraListingCard newCard = new bakraListingCard();
            newCard.AnimalTitle = "New Animal #" + animalCounter;
            newCard.AnimalPrice = "PKR 60,000";
            newCard.AnimalLocation = "Karachi";
            newCard.AnimalDetails = "Added from code";

            // Place it dynamically
            newCard.Location = new Point(50, nextY);

            this.Controls.Add(newCard);
            animalCounter++;
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            bakraListingCard lastCard = null;
            int maxY = -1;

            // Find the card sitting at the very bottom of the stack
            foreach (Control c in this.Controls)
            {
                if (c is bakraListingCard)
                {
                    if (c.Location.Y > maxY)
                    {
                        maxY = c.Location.Y;
                        lastCard = (bakraListingCard)c;
                    }
                }
            }

            // If we found a card, delete it
            if (lastCard != null)
            {
                this.Controls.Remove(lastCard);
                lastCard.Dispose(); // Clears it from the computer's memory
            }
        }
    }
}