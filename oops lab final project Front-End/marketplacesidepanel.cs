using System;
using System.Drawing;
using System.Windows.Forms;

namespace oops_lab_final_project_Front_End
{
    public partial class marketplacesidepanel : Form
    {
        // Counter for the newly added animals
        int animalCounter = 1;

        // Tracks which card is currently clicked/selected
        private bakraListingCard selectedCard = null;

        public marketplacesidepanel()
        {
            InitializeComponent();
        }

        // --- HELPER METHOD FOR SELECTION HIGHLIGHT ---
        private void SelectAnimalCard(bakraListingCard clickedCard)
        {
            // Reset the background color of the PREVIOUSLY selected card
            if (selectedCard != null)
            {
                selectedCard.BackColor = Color.White; // Change this if your default card color is different
            }

            // Set the new selection and highlight it blue!
            selectedCard = clickedCard;
            selectedCard.BackColor = Color.LightBlue;
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

                // Make the default cards clickable for selection!
                newAnimalCard.Click += (s, ev) => { SelectAnimalCard(newAnimalCard); };
                foreach (Control child in newAnimalCard.Controls)
                {
                    child.Click += (s, ev) => { SelectAnimalCard(newAnimalCard); };
                }

                // Force it onto the screen
                this.Controls.Add(newAnimalCard);
            }
        }

        // --- NEWLY ADDED BUTTON FUNCTIONS BELOW ---

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddBakraForm myPopup = new AddBakraForm();

            // 1. Only add the card IF the user clicked OK (and didn't just cross out of the window)
            if (myPopup.ShowDialog() == DialogResult.OK)
            {
                int nextY = 20; // Default starting position if the screen is empty

                // Find the lowest card currently on the screen so we don't overlap
                foreach (Control c in this.Controls)
                {
                    if (c is bakraListingCard)
                    {
                        if (c.Location.Y >= nextY)
                        {
                            nextY = c.Location.Y + 160; // Match the 160 spacing
                        }
                    }
                }

                // 2. Build the new card and inject the live data from the popup!
                bakraListingCard newCard = new bakraListingCard();
                newCard.AnimalTitle = myPopup.NewTitle;
                newCard.AnimalPrice = "PKR " + myPopup.NewPrice;
                newCard.AnimalLocation = myPopup.NewLocation;
                newCard.AnimalDetails = myPopup.NewTeeth + " Teeth | " + myPopup.NewWeight + " kg";

                // Place it dynamically
                newCard.Location = new Point(50, nextY);

                // Make the newly added card clickable for selection too!
                newCard.Click += (s, ev) => { SelectAnimalCard(newCard); };
                foreach (Control child in newCard.Controls)
                {
                    child.Click += (s, ev) => { SelectAnimalCard(newCard); };
                }

                this.Controls.Add(newCard);
                animalCounter++;
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            // 1. Check if they actually selected a card first
            if (selectedCard == null)
            {
                MessageBox.Show("Please select an animal card first by clicking on it!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Remove it from the screen and clear memory
            this.Controls.Remove(selectedCard);
            selectedCard.Dispose();
            selectedCard = null; // Clear tracking reference

            // 3. RE-ARRANGE layout instantly so remaining cards shift up and fill the gap!
            int currentY = 20; // Starting top position

            foreach (Control c in this.Controls)
            {
                if (c is bakraListingCard)
                {
                    c.Location = new Point(50, currentY);
                    currentY += 160; // Keep your standard layout spacing
                }
            }

            MessageBox.Show("Animal listing removed successfully!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}