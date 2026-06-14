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
    public partial class confirmnewpasswordpage : Form
    {
        private string usernameToReset = "";

        public confirmnewpasswordpage(string username)
        {
            InitializeComponent();
            usernameToReset = username;
        }

        private void btnconfirmnewpassword_Click(object sender, EventArgs e)
        {
            string newPassword = writenewpassword.Text.Trim();
            string confirmPassword = writeconfirmnewpassword.Text.Trim();

            // Khali fields check
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill both fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Password match check
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // File mein update karo
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No users found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool userFound = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length >= 3)
                {
                    string savedUser = parts[0].Trim();
                    if (savedUser.Equals(usernameToReset, StringComparison.OrdinalIgnoreCase))
                    {
                        lines[i] = savedUser + "," + newPassword + "," + parts[2].Trim();
                        userFound = true;
                        break;
                    }
                }
            }

            if (userFound)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Password changed! Please login again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loginpage login = new loginpage();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}