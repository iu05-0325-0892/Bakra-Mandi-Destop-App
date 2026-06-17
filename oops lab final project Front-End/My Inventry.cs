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
    public partial class My_Inventry : Form
    {
        public My_Inventry()
        {
            InitializeComponent();
        }

        private void My_Inventry_Load(object sender, EventArgs e)
        {
            int currentY = 20;

            foreach (bakraListingCard savedCard in marketplacesidepanel.InventoryDatabase)
            {
                // 1. Create a fresh visual card
                bakraListingCard displayCard = new bakraListingCard();

                // 2. Copy the data
                displayCard.AnimalTitle = savedCard.AnimalTitle;
                displayCard.AnimalPrice = savedCard.AnimalPrice;
                displayCard.AnimalLocation = savedCard.AnimalLocation;
                displayCard.AnimalDetails = savedCard.AnimalDetails;

                // 3. Position it
                displayCard.Location = new Point(50, currentY);
                currentY += 160;

                this.Controls.Add(displayCard);
                displayCard.Refresh();
            }
        }
    }
}
