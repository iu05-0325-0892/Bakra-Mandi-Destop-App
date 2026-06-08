
namespace oops_lab_final_project_Front_End
{
    partial class confirmnewpasswordpage
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
            this.txtconfirmnewpassword = new System.Windows.Forms.Label();
            this.txtnewpassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.writenewpassword = new System.Windows.Forms.TextBox();
            this.writeconfirmnewpassword = new System.Windows.Forms.TextBox();
            this.btnconfirmnewpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtconfirmnewpassword
            // 
            this.txtconfirmnewpassword.AutoSize = true;
            this.txtconfirmnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtconfirmnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmnewpassword.ForeColor = System.Drawing.Color.Azure;
            this.txtconfirmnewpassword.Location = new System.Drawing.Point(216, 53);
            this.txtconfirmnewpassword.Name = "txtconfirmnewpassword";
            this.txtconfirmnewpassword.Size = new System.Drawing.Size(230, 25);
            this.txtconfirmnewpassword.TabIndex = 0;
            this.txtconfirmnewpassword.Text = "Confirm new password";
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.AutoSize = true;
            this.txtnewpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnewpassword.ForeColor = System.Drawing.Color.Azure;
            this.txtnewpassword.Location = new System.Drawing.Point(199, 118);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(126, 18);
            this.txtnewpassword.TabIndex = 1;
            this.txtnewpassword.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(134, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirm New Password:";
            // 
            // writenewpassword
            // 
            this.writenewpassword.Location = new System.Drawing.Point(359, 115);
            this.writenewpassword.Name = "writenewpassword";
            this.writenewpassword.Size = new System.Drawing.Size(100, 20);
            this.writenewpassword.TabIndex = 3;
            // 
            // writeconfirmnewpassword
            // 
            this.writeconfirmnewpassword.Location = new System.Drawing.Point(359, 160);
            this.writeconfirmnewpassword.Name = "writeconfirmnewpassword";
            this.writeconfirmnewpassword.Size = new System.Drawing.Size(100, 20);
            this.writeconfirmnewpassword.TabIndex = 4;
            // 
            // btnconfirmnewpassword
            // 
            this.btnconfirmnewpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmnewpassword.Location = new System.Drawing.Point(260, 215);
            this.btnconfirmnewpassword.Name = "btnconfirmnewpassword";
            this.btnconfirmnewpassword.Size = new System.Drawing.Size(154, 28);
            this.btnconfirmnewpassword.TabIndex = 5;
            this.btnconfirmnewpassword.Text = "confirm password";
            this.btnconfirmnewpassword.UseVisualStyleBackColor = true;
            this.btnconfirmnewpassword.Click += new System.EventHandler(this.btnconfirmnewpassword_Click);
            // 
            // confirmnewpasswordpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.confrim_new_password_page;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnconfirmnewpassword);
            this.Controls.Add(this.writeconfirmnewpassword);
            this.Controls.Add(this.writenewpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtconfirmnewpassword);
            this.Name = "confirmnewpasswordpage";
            this.Text = "confirmnewpasswordpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtconfirmnewpassword;
        private System.Windows.Forms.Label txtnewpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox writenewpassword;
        private System.Windows.Forms.TextBox writeconfirmnewpassword;
        private System.Windows.Forms.Button btnconfirmnewpassword;
    }
}