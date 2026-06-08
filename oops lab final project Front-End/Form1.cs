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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        // This is your main Login button
        private void btnloginin_Click(object sender, EventArgs e)
        {
            
            string inputUsername = txtusername.Text.Trim();
            string inputPassword = txtpassword.Text.Trim();

            bool loginSuccess = false;
            string userRole = "";

            // 2. Search our temporary database for a match
            foreach (User u in TempDatabase.Users)
            {
                if (u.Username == inputUsername && u.Password == inputPassword)
                {
                    loginSuccess = true;
                    userRole = u.Role; // Grab whether they are a Buyer or Seller
                    break; // Stop searching, we found them!
                }
            }

            // 3. Decide what to do
            if (loginSuccess == true)
            {
                // Pass the correct role to the Dashboard
                MainDashboard mainPage = new MainDashboard(userRole);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                // Pop up an error if they typed the wrong password
                MessageBox.Show("Invalid Username or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // This is your Create Account button
        private void btncreatenewacc_Click(object sender, EventArgs e)
        {
            RegisterForm regPage = new RegisterForm();
            regPage.Show();
            this.Hide();
        }

        // This is your Forgot Password button
        private void btnforgotpassword_Click(object sender, EventArgs e)
        {
            Forgotpasswordpage forgotPage = new Forgotpasswordpage();
            forgotPage.Show();
            this.Hide();
        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }
    }
}