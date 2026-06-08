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
    public partial class MainDashboard : Form
    {
        public string currentUserRole = "";

        // CONSTRUCTOR 1: The empty one to keep the Visual Studio Designer happy!
        public MainDashboard()
        {
            InitializeComponent();
        }

        // CONSTRUCTOR 2: The one our Login Page uses to pass the User Role!
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

        }
    }
}