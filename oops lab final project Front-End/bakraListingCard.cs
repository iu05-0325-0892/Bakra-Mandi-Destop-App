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
    }
}
