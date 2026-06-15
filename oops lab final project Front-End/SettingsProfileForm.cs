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
    public partial class SettingsProfileForm : Form
    {
        // 1. ADDED THIS: The memory slot to hold whoever is currently logged in!
        public string LoggedInUsername { get; set; }

        public SettingsProfileForm()
        {
            InitializeComponent();
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White || this.BackColor == SystemColors.Control)
            {
                this.BackColor = Color.FromArgb(45, 45, 48); // A nice professional dark gray
                this.ForeColor = Color.White; // Make all standard text white so it's readable
                btntoggledarkmode.Text = "Switch to Light Mode";
            }
            else
            {
                // Switch back to light mode
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                btntoggledarkmode.Text = "Switch to Dark Mode";
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // 2. CHANGED THIS: It now passes the actual user's name instead of empty quotes!
            confirmnewpasswordpage passwordForm = new confirmnewpasswordpage(LoggedInUsername);

            // Open it as a popup so the user has to deal with it before doing anything else
            passwordForm.ShowDialog();
        }

        private void SettingsProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}