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
    public partial class Forgotpasswordpage : Form
    {
        public Forgotpasswordpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtforgotusername.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No users found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool userFound = false;
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 3)
                {
                    string savedUser = parts[0].Trim();
                    if (savedUser.Equals(username, StringComparison.OrdinalIgnoreCase))
                    {
                        userFound = true;
                        break;
                    }
                }
            }

            if (userFound)
            {
                confirmnewpasswordpage confirmPage = new confirmnewpasswordpage(username);
                confirmPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username not found! Please check your username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ye 2 khali functions zaroori hain — delete mat karna!
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }
    }
}