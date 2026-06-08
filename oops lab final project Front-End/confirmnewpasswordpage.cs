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
    public partial class confirmnewpasswordpage : Form
    {
        public confirmnewpasswordpage()
        {
            InitializeComponent();
        }

        private void btnconfirmnewpassword_Click(object sender, EventArgs e)
        {
           
            loginpage login = new loginpage();

           
            login.Show();

            
            this.Hide();
        }
    }
}
