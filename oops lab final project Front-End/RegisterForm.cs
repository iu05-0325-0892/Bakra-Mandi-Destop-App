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
    public partial class RegisterForm : Form
    {
        // Role ko store karne ke liye variable (Default: Buyer)
        private string selectedRole = "Buyer";

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Agar user Buyer wale button par click kare
        private void btnbuyer_Click(object sender, EventArgs e)
        {
            selectedRole = "Buyer";
            MessageBox.Show("Selected Role: Buyer", "Role Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Agar user Seller wale button par click kare
        private void btnseller_Click(object sender, EventArgs e)
        {
            selectedRole = "Seller";
            MessageBox.Show("Selected Role: Seller", "Role Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string uName = writeusername.Text.Trim();
            string pass = writenewpassword.Text.Trim();

            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Path ko fix kar diya taake dono forms ek hi file use karein
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");
           

            string userData = uName + "," + pass + "," + selectedRole + Environment.NewLine;

            File.AppendAllText(filePath, userData);

            MessageBox.Show("Registration Successful! Now you can Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loginpage login = new loginpage();
            login.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void writefirstname_TextChanged(object sender, EventArgs e) { }
        private void RegisterForm_Load(object sender, EventArgs e) { }
    }
}