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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Yahan 'object' daal kar error fix kar diya hai
        private void btnsignup_Click(object sender, EventArgs e)
        {
            string uName = txtusername.Text.Trim();
            string pass = writenewpassword.Text.Trim();
            string selectedRole = "Buyer";

            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User newAccount = new User();
            newAccount.Username = uName;
            newAccount.Password = pass;
            newAccount.Role = selectedRole;

            TempDatabase.Users.Add(newAccount);

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