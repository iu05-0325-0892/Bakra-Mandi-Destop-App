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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void btnloginin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtusername.Text.Trim();
            string inputPassword = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No registered users found! Please register first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool loginSuccess = false;
            string userRole = "Buyer";

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string savedUser = parts[0].Trim();
                    string savedPass = parts[1].Trim();
                    string savedRole = parts[2].Trim().ToLower() == "seller" ? "Seller" : "Buyer"; // ← FIX

                    if (savedUser.Equals(inputUsername, StringComparison.OrdinalIgnoreCase) && savedPass == inputPassword)
                    {
                        loginSuccess = true;
                        userRole = savedRole;
                        break;
                    }
                }
            }

            if (loginSuccess == true)
            {
                MessageBox.Show("Login Successful! Welcome " + inputUsername, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainDashboard mainPage = new MainDashboard(userRole);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncreatenewacc_Click(object sender, EventArgs e)
        {
            RegisterForm regPage = new RegisterForm();
            regPage.Show();
            this.Hide();
        }

        private void btnforgotpassword_Click(object sender, EventArgs e)
        {
            Forgotpasswordpage forgotPage = new Forgotpasswordpage();
            forgotPage.Show();
            this.Hide();
        }

        private void txtusername_Click(object sender, EventArgs e) { }
    }
}