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
            btnmarketplace.Visible = false;
            btnsell.Visible = false;

            if (currentUserRole == "Seller")
            {
                btnsell.Visible = true;
            }
            else if (currentUserRole == "Buyer")
            {
                btnmarketplace.Visible = true;
            }
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            AddBakraForm addForm = new AddBakraForm();

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                // Khali fields check
                if (string.IsNullOrEmpty(addForm.NewTitle) ||
                    string.IsNullOrEmpty(addForm.NewPrice) ||
                    string.IsNullOrEmpty(addForm.NewLocation) ||
                    string.IsNullOrEmpty(addForm.NewTeeth) ||
                    string.IsNullOrEmpty(addForm.NewWeight))
                {
                    MessageBox.Show("Please fill all fields!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // File mein save karo
                string filePath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "goats.txt");

                string goatData = addForm.NewTitle + "," +
                                  addForm.NewPrice + "," +
                                  addForm.NewLocation + "," +
                                  addForm.NewTeeth + "," +
                                  addForm.NewWeight +
                                  Environment.NewLine;

                File.AppendAllText(filePath, goatData);

                MessageBox.Show("Bakra successfully listed! 🐐", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            SettingsProfileForm mySettings = new SettingsProfileForm();
            mySettings.LoggedInUsername = currentUserRole;
            mySettings.Show();
        }

        private void btnInbox_Click(object sender, EventArgs e)
        {
            inboxsidepanel myInbox = new inboxsidepanel();
            myInbox.Show();
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { }
    }
}