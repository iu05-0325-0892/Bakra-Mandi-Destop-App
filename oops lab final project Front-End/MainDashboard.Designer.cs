namespace oops_lab_final_project_Front_End
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.btnsell = new System.Windows.Forms.Button();
            this.maindashboardsidepanel = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnviewsales = new System.Windows.Forms.Button();
            this.btnmyanimal = new System.Windows.Forms.Button();
            this.btninbox = new System.Windows.Forms.Button();
            this.btnmarketplace = new System.Windows.Forms.Button();
            this.btnsphome = new System.Windows.Forms.Button();
            this.bakraListingCard1 = new oops_lab_final_project_Front_End.bakraListingCard();
            this.maindashboardsidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsell
            // 
            this.btnsell.BackColor = System.Drawing.Color.Maroon;
            this.btnsell.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsell.Location = new System.Drawing.Point(352, 617);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(950, 75);
            this.btnsell.TabIndex = 4;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = false;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // maindashboardsidepanel
            // 
            this.maindashboardsidepanel.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.sidepanel;
            this.maindashboardsidepanel.Controls.Add(this.btnlogout);
            this.maindashboardsidepanel.Controls.Add(this.btnsettings);
            this.maindashboardsidepanel.Controls.Add(this.btnhistory);
            this.maindashboardsidepanel.Controls.Add(this.btnviewsales);
            this.maindashboardsidepanel.Controls.Add(this.btnmyanimal);
            this.maindashboardsidepanel.Controls.Add(this.btninbox);
            this.maindashboardsidepanel.Controls.Add(this.btnmarketplace);
            this.maindashboardsidepanel.Controls.Add(this.btnsphome);
            this.maindashboardsidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maindashboardsidepanel.Location = new System.Drawing.Point(0, 0);
            this.maindashboardsidepanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maindashboardsidepanel.Name = "maindashboardsidepanel";
            this.maindashboardsidepanel.Size = new System.Drawing.Size(352, 692);
            this.maindashboardsidepanel.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Azure;
            this.btnlogout.Location = new System.Drawing.Point(0, 641);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(352, 51);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click_1);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.Transparent;
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.Azure;
            this.btnsettings.Location = new System.Drawing.Point(0, 288);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(352, 51);
            this.btnsettings.TabIndex = 6;
            this.btnsettings.Text = "Settings Profile";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.Color.Transparent;
            this.btnhistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhistory.ForeColor = System.Drawing.Color.Azure;
            this.btnhistory.Location = new System.Drawing.Point(0, 237);
            this.btnhistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(352, 51);
            this.btnhistory.TabIndex = 5;
            this.btnhistory.Text = "Order History";
            this.btnhistory.UseVisualStyleBackColor = false;
            // 
            // btnviewsales
            // 
            this.btnviewsales.BackColor = System.Drawing.Color.Transparent;
            this.btnviewsales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnviewsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewsales.ForeColor = System.Drawing.Color.Azure;
            this.btnviewsales.Location = new System.Drawing.Point(0, 186);
            this.btnviewsales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnviewsales.Name = "btnviewsales";
            this.btnviewsales.Size = new System.Drawing.Size(352, 51);
            this.btnviewsales.TabIndex = 4;
            this.btnviewsales.Text = "View Sales";
            this.btnviewsales.UseVisualStyleBackColor = false;
            // 
            // btnmyanimal
            // 
            this.btnmyanimal.BackColor = System.Drawing.Color.Transparent;
            this.btnmyanimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmyanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmyanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyanimal.ForeColor = System.Drawing.Color.Azure;
            this.btnmyanimal.Location = new System.Drawing.Point(0, 135);
            this.btnmyanimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmyanimal.Name = "btnmyanimal";
            this.btnmyanimal.Size = new System.Drawing.Size(352, 51);
            this.btnmyanimal.TabIndex = 3;
            this.btnmyanimal.Text = "My Animals / Inventory";
            this.btnmyanimal.UseVisualStyleBackColor = false;
            // 
            // btninbox
            // 
            this.btninbox.BackColor = System.Drawing.Color.Transparent;
            this.btninbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninbox.ForeColor = System.Drawing.Color.Azure;
            this.btninbox.Location = new System.Drawing.Point(0, 84);
            this.btninbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btninbox.Name = "btninbox";
            this.btninbox.Size = new System.Drawing.Size(352, 51);
            this.btninbox.TabIndex = 2;
            this.btninbox.Text = "Messages / Inbox";
            this.btninbox.UseVisualStyleBackColor = false;
            this.btninbox.Click += new System.EventHandler(this.btninbox_Click_2);
            // 
            // btnmarketplace
            // 
            this.btnmarketplace.BackColor = System.Drawing.Color.Transparent;
            this.btnmarketplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmarketplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmarketplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarketplace.ForeColor = System.Drawing.Color.Azure;
            this.btnmarketplace.Location = new System.Drawing.Point(0, 42);
            this.btnmarketplace.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmarketplace.Name = "btnmarketplace";
            this.btnmarketplace.Size = new System.Drawing.Size(352, 42);
            this.btnmarketplace.TabIndex = 1;
            this.btnmarketplace.Text = "Marketplace";
            this.btnmarketplace.UseVisualStyleBackColor = false;
            this.btnmarketplace.Click += new System.EventHandler(this.btnmarketplace_Click);
            // 
            // btnsphome
            // 
            this.btnsphome.BackColor = System.Drawing.Color.Transparent;
            this.btnsphome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsphome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsphome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsphome.ForeColor = System.Drawing.Color.Azure;
            this.btnsphome.Location = new System.Drawing.Point(0, 0);
            this.btnsphome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsphome.Name = "btnsphome";
            this.btnsphome.Size = new System.Drawing.Size(352, 42);
            this.btnsphome.TabIndex = 0;
            this.btnsphome.Text = "Home";
            this.btnsphome.UseVisualStyleBackColor = false;
            this.btnsphome.Click += new System.EventHandler(this.btnsphome_Click);
            // 
            // bakraListingCard1
            // 
            this.bakraListingCard1.AnimalDetails = "2 Teeth | 40 kg | Male";
            this.bakraListingCard1.AnimalLocation = "karachi";
            this.bakraListingCard1.AnimalPrice = "PKR 50,000";
            this.bakraListingCard1.AnimalTitle = "Beautiful White Bakra";
            this.bakraListingCard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bakraListingCard1.BackgroundImage")));
            this.bakraListingCard1.ForeColor = System.Drawing.Color.Black;
            this.bakraListingCard1.Location = new System.Drawing.Point(352, 0);
            this.bakraListingCard1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bakraListingCard1.Name = "bakraListingCard1";
            this.bakraListingCard1.Size = new System.Drawing.Size(882, 208);
            this.bakraListingCard1.TabIndex = 5;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.alpine_goat_alpine_goat_alpine_goat_alpine_goat_floral_goat_farm_farm;
            this.ClientSize = new System.Drawing.Size(1302, 692);
            this.Controls.Add(this.bakraListingCard1);
            this.Controls.Add(this.btnsell);
            this.Controls.Add(this.maindashboardsidepanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.maindashboardsidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel maindashboardsidepanel;
        private System.Windows.Forms.Button btnmarketplace;
        private System.Windows.Forms.Button btnsphome;
        private System.Windows.Forms.Button btninbox;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.Button btnmyanimal;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnviewsales;
        private bakraListingCard bakraListingCard1;
    }
}