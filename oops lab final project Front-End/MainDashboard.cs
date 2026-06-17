using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            // 1. Hide everything by default so nothing leaks
            btnmarketplace.Visible = false;
            btnmyanimal.Visible = false;
            
            btnhistory.Visible = false;
            btnsell.Visible = false; // Your original sell button hide logic is still here!

            // 2. Show buttons based on role
            if (currentUserRole == "Seller")
            {
                btnmyanimal.Visible = true;
               
                btnsell.Visible = true; // Show it ONLY if they are a Seller (Safe!)
                btnmarketplace.Visible = true;
            }
            else if (currentUserRole == "Buyer")
            {
                btnmarketplace.Visible = true;
                btnhistory.Visible = true;
                // Buyer does NOT get the Sell button
            }
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            AddBakraForm addForm = new AddBakraForm();

        private void btnInbox_Click(object sender, EventArgs e)
        {
            // inboxsidepanel myInbox = new inboxsidepanel();
            //  myInbox.Show();
        }

        private void btninbox_Click_1(object sender, EventArgs e)
        {
            //   inboxsidepanel myInbox = new inboxsidepanel();
            //  myInbox.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            // Empty click event
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnmarketplace_Click(object sender, EventArgs e)
        {
            marketplacesidepanel marketPage = new marketplacesidepanel();
            marketPage.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loginpage loginPage = new loginpage();
            loginPage.Show();
            this.Hide();
        }

        private void btnlogout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You have been successfully logged out.", "Logged Out",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginpage myLogin = new loginpage();
            myLogin.Show();
            this.Hide();
        }

        private void btninbox_Click_1(object sender, EventArgs e)
        {
            inboxsidepanel myInbox = new inboxsidepanel();
            myInbox.Show();
        }

        private void btninbox_Click_2(object sender, EventArgs e)
        {
            inboxsidepanel myInbox = new inboxsidepanel();
            myInbox.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            // 1. Create the Settings page
            SettingsProfileForm mySettings = new SettingsProfileForm();

            // 2. Hand it the username (using a test name for now)
            mySettings.LoggedInUsername = "TestUser";

            // 3. Show the settings page
            mySettings.Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of your order history form
            orderhistory historyForm = new orderhistory();

            // 2. Show it on screen
            historyForm.Show();
        }

        private void btnmyanimal_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of your inventory form
            My_Inventry inventoryForm = new My_Inventry();

            // 2. Show the page as a normal window!
            inventoryForm.Show();
        }
    }
}
