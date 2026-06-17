
namespace oops_lab_final_project_Front_End
{
    partial class marketplacesidepanel
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnbuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(0, 427);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(710, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "add animal";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnremove
            // 
            this.btnremove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(0, 398);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(710, 29);
            this.btnremove.TabIndex = 1;
            this.btnremove.Text = "remove animal";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnbuy
            // 
            this.btnbuy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnbuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuy.Location = new System.Drawing.Point(0, 375);
            this.btnbuy.Name = "btnbuy";
            this.btnbuy.Size = new System.Drawing.Size(710, 23);
            this.btnbuy.TabIndex = 2;
            this.btnbuy.Text = "BUY";
            this.btnbuy.UseVisualStyleBackColor = true;
            this.btnbuy.Click += new System.EventHandler(this.btnbuy_Click);
            // 
            // marketplacesidepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.card;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.btnbuy);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnadd);
            this.Name = "marketplacesidepanel";
            this.Text = "marketplacesidepanel";
            this.Load += new System.EventHandler(this.marketplacesidepanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnbuy;
    }
}