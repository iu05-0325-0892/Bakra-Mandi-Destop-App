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
            // 1. Create an instance of the Forgotpasswordpage instead
            Forgotpasswordpage forgotForm = new Forgotpasswordpage();

            // 2. Open it as a popup window
            forgotForm.ShowDialog();
        }

        // 🛠️ NEW ADDITION: Click on the profile image box to update it dynamically
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // 1. Open the computer's native file explorer dialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 2. Limit the selection to standard image formats only
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            // 3. If a user selects a file and hits open/confirm
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 4. Instantiate a new Bitmap from the chosen path and assign it to your image block
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);

                MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SettingsProfileForm_Load(object sender, EventArgs e)
        {

        }
    }
}