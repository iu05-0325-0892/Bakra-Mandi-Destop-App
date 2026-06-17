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
    public partial class bakraListingCard : UserControl
    {
       

        public string AnimalTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string AnimalPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public string AnimalLocation
        {
            get { return lblLocation.Text; }
            set { lblLocation.Text = value; }
        }

        public string AnimalDetails
        {
            get { return lblDetails.Text; }
            set { lblDetails.Text = value; }
        }
        public bakraListingCard()
        {
            InitializeComponent();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone No: 03362039162", "Contact Seller");
        }
        public void SetBakraDetails(string title, string price, string location, string teeth, string weight)
        {
            // Change label1, label2 to whatever your card's labels are named
            lblTitle.Text = title;
            lblPrice.Text = "PKR " + price;
            lblLocation.Text = location;
            lblDetails.Text = teeth + " Teeth | " + weight + " kg";
        }
       
        public void MarkAsSold()
        {
           
            this.BackColor = Color.LightGray;

           
            this.Enabled = false;

        }
        private void bakraListingCard_Load(object sender, EventArgs e)
        {
            
           
        }

        private void bakraListingCard_Click(object sender, EventArgs e)
        {
            
            }
        }
    }

