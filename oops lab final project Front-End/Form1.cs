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

        private void txtloginpage_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            
            RegisterForm regPage = new RegisterForm();

           
            regPage.Show();

            
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
         
           
        }

        private void btncreateac_Click(object sender, EventArgs e)
        {
           
            RegisterForm regPage = new RegisterForm();

            
            regPage.Show();

           
            this.Hide();
        }

        
        RegisterForm regPage = new RegisterForm();

        private void btncreatenewacc_Click(object sender, EventArgs e)
        {
          
            RegisterForm regPage = new RegisterForm();

          
            regPage.Show();

         
            this.Hide();
        }
    }
}
