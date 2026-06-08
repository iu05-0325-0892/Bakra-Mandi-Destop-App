
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
            this.maindashboardsidepanel = new System.Windows.Forms.Panel();
            this.btnsphome = new System.Windows.Forms.Button();
            this.btnmarketplace = new System.Windows.Forms.Button();
            this.btninbox = new System.Windows.Forms.Button();
            this.btnmyanimal = new System.Windows.Forms.Button();
            this.maindashboardsidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // maindashboardsidepanel
            // 
            this.maindashboardsidepanel.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.sidepanel;
            this.maindashboardsidepanel.Controls.Add(this.btnmyanimal);
            this.maindashboardsidepanel.Controls.Add(this.btninbox);
            this.maindashboardsidepanel.Controls.Add(this.btnmarketplace);
            this.maindashboardsidepanel.Controls.Add(this.btnsphome);
            this.maindashboardsidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.maindashboardsidepanel.Location = new System.Drawing.Point(0, 0);
            this.maindashboardsidepanel.Name = "maindashboardsidepanel";
            this.maindashboardsidepanel.Size = new System.Drawing.Size(211, 450);
            this.maindashboardsidepanel.TabIndex = 0;
            // 
            // btnsphome
            // 
            this.btnsphome.BackColor = System.Drawing.Color.Transparent;
            this.btnsphome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsphome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsphome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsphome.ForeColor = System.Drawing.Color.Azure;
            this.btnsphome.Location = new System.Drawing.Point(0, 0);
            this.btnsphome.Name = "btnsphome";
            this.btnsphome.Size = new System.Drawing.Size(211, 27);
            this.btnsphome.TabIndex = 0;
            this.btnsphome.Text = "Home";
            this.btnsphome.UseVisualStyleBackColor = false;
            this.btnsphome.Click += new System.EventHandler(this.btnsphome_Click);
            // 
            // btnmarketplace
            // 
            this.btnmarketplace.BackColor = System.Drawing.Color.Transparent;
            this.btnmarketplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmarketplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmarketplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarketplace.ForeColor = System.Drawing.Color.Azure;
            this.btnmarketplace.Location = new System.Drawing.Point(0, 27);
            this.btnmarketplace.Name = "btnmarketplace";
            this.btnmarketplace.Size = new System.Drawing.Size(211, 27);
            this.btnmarketplace.TabIndex = 1;
            this.btnmarketplace.Text = "Marketplace";
            this.btnmarketplace.UseVisualStyleBackColor = false;
            // 
            // btninbox
            // 
            this.btninbox.BackColor = System.Drawing.Color.Transparent;
            this.btninbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninbox.ForeColor = System.Drawing.Color.Azure;
            this.btninbox.Location = new System.Drawing.Point(0, 54);
            this.btninbox.Name = "btninbox";
            this.btninbox.Size = new System.Drawing.Size(211, 33);
            this.btninbox.TabIndex = 2;
            this.btninbox.Text = "Messages / Inbox";
            this.btninbox.UseVisualStyleBackColor = false;
            // 
            // btnmyanimal
            // 
            this.btnmyanimal.BackColor = System.Drawing.Color.Transparent;
            this.btnmyanimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmyanimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmyanimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmyanimal.ForeColor = System.Drawing.Color.Azure;
            this.btnmyanimal.Location = new System.Drawing.Point(0, 87);
            this.btnmyanimal.Name = "btnmyanimal";
            this.btnmyanimal.Size = new System.Drawing.Size(211, 33);
            this.btnmyanimal.TabIndex = 3;
            this.btnmyanimal.Text = "My Animals / Inventory";
            this.btnmyanimal.UseVisualStyleBackColor = false;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.maindashboardsidepanel);
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
        private System.Windows.Forms.Button btnmyanimal;
    }
}