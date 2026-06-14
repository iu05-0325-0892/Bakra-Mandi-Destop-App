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

        // CONSTRUCTOR 1
        public MainDashboard()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR 2
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
            // --- ROLE MANAGEMENT LOGIC ---
            btnmarketplace.Visible = false;

            // In missing buttons ko humne poori tarah disable kar diya hai taake crash na ho
            // btnManageInventory.Visible = false;
            // btnviewsales.Visible = false;
            // btnorderhistory.Visible = false;

            btnsell.Visible = false; // Hide the Sell button by default

            if (currentUserRole == "Seller")
            {
                // btnManageInventory.Visible = true;
                // btnviewsales.Visible = true;
                btnsell.Visible = true; // Show it ONLY if they are a Seller
            }
            else if (currentUserRole == "Buyer")
            {
                btnmarketplace.Visible = true;
                // btnorderhistory.Visible = true;
                // Buyer does NOT get the Sell button
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
            // inboxsidepanel myInbox = new inboxsidepanel();
            //  myInbox.Show();
        }

        private void btninbox_Click_1(object sender, EventArgs e)
        {
            //   inboxsidepanel myInbox = new inboxsidepanel();
            //  myInbox.Show();
        }

        private void btnsplogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been successfully logged out.", "Logged Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginpage myLogin = new loginpage();
            myLogin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Empty click event
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Empty click event
        }

        private void btnmarketplace_Click(object sender, EventArgs e)
        {
            // marketplacesidepanel marketPage = new marketplacesidepanel();
            // marketPage.Show();
        }
    }
}