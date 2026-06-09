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
    public partial class MainDashboard : Form
    {
        public string currentUserRole = "";

        // CONSTRUCTOR 1: The empty one to keep the Visual Studio Designer happy!
        public MainDashboard()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR 2: The one our Login Page uses to pass the User Role!
        public MainDashboard(string role)
        {
            InitializeComponent();
            currentUserRole = role;
        }

        private void btnsphome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are currently on the Main Dashboard Home!", "Home Screen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

            btnmarketplace.Visible = false;
            btnManageInventory.Visible = false;
            btnviewsales.Visible = false;
            btnorderhistory.Visible = false;

            if (currentUserRole == "Seller")
            {

                btnManageInventory.Visible = true;
                btnviewsales.Visible = true;
            }
            else if (currentUserRole == "Buyer")
            {

                btnmarketplace.Visible = true;
                btnorderhistory.Visible = true;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            loginpage loginPage = new loginpage();


            loginPage.Show();


            this.Hide();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {

            inboxsidepanel myInbox = new inboxsidepanel();

            myInbox.Show();
           
           
        }

        private void btninbox_Click_1(object sender, EventArgs e)
        {
           
            inboxsidepanel myInbox = new inboxsidepanel();
            myInbox.Show();
        }
    }
}

