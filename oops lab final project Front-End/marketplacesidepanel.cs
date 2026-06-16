using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace oops_lab_final_project_Front_End
{
    public partial class marketplacesidepanel : Form
    {
        private bakraListingCard selectedCard = null;

        public marketplacesidepanel()
        {
            InitializeComponent();
        }

        private void SelectAnimalCard(bakraListingCard clickedCard)
        {
            if (selectedCard != null)
            {
                selectedCard.BackColor = Color.White;
            }
            selectedCard = clickedCard;
            selectedCard.BackColor = Color.LightBlue;
        }

        private void marketplacesidepanel_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;

            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "goats.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Abhi koi bakra listed nahi hai!", "Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            int verticalSpacing = 20;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    bakraListingCard newAnimalCard = new bakraListingCard();

                    newAnimalCard.AnimalTitle = parts[0].Trim();
                    newAnimalCard.AnimalPrice = "PKR " + parts[1].Trim();
                    newAnimalCard.AnimalLocation = parts[2].Trim();
                    newAnimalCard.AnimalDetails = parts[3].Trim() + " Teeth | " + parts[4].Trim() + " kg";

                    newAnimalCard.Location = new Point(50, verticalSpacing);
                    verticalSpacing += 160;

                    newAnimalCard.Click += (s, ev) => { SelectAnimalCard(newAnimalCard); };
                    foreach (Control child in newAnimalCard.Controls)
                    {
                        child.Click += (s, ev) => { SelectAnimalCard(newAnimalCard); };
                    }

                    this.Controls.Add(newAnimalCard);
                }
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddBakraForm myPopup = new AddBakraForm();

            if (myPopup.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "goats.txt");

                string goatData = myPopup.NewTitle + "," +
                                  myPopup.NewPrice + "," +
                                  myPopup.NewLocation + "," +
                                  myPopup.NewTeeth + "," +
                                  myPopup.NewWeight +
                                  Environment.NewLine;

                File.AppendAllText(filePath, goatData);

                int nextY = 20;
                foreach (Control c in this.Controls)
                {
                    if (c is bakraListingCard)
                    {
                        if (c.Location.Y >= nextY)
                        {
                            nextY = c.Location.Y + 160;
                        }
                    }
                }

                bakraListingCard newCard = new bakraListingCard();
                newCard.AnimalTitle = myPopup.NewTitle;
                newCard.AnimalPrice = "PKR " + myPopup.NewPrice;
                newCard.AnimalLocation = myPopup.NewLocation;
                newCard.AnimalDetails = myPopup.NewTeeth + " Teeth | " + myPopup.NewWeight + " kg";

                newCard.Location = new Point(50, nextY);

                newCard.Click += (s, ev) => { SelectAnimalCard(newCard); };
                foreach (Control child in newCard.Controls)
                {
                    child.Click += (s, ev) => { SelectAnimalCard(newCard); };
                }

                this.Controls.Add(newCard);

                MessageBox.Show("Bakra successfully listed! 🐐", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if (selectedCard == null)
            {
                MessageBox.Show("Please select an animal card first!", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Controls.Remove(selectedCard);
            selectedCard.Dispose();
            selectedCard = null;

            int currentY = 20;
            foreach (Control c in this.Controls)
            {
                if (c is bakraListingCard)
                {
                    c.Location = new Point(50, currentY);
                    currentY += 160;
                }
            }

            MessageBox.Show("Bakra removed successfully!", "Removed",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}