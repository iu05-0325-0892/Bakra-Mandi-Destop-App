
namespace oops_lab_final_project_Front_End
{
    partial class loginpage
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
            this.txtloginpage = new System.Windows.Forms.Label();
            this.writeusername = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.Label();
            this.writepassword = new System.Windows.Forms.TextBox();
            this.btnforgotpassword = new System.Windows.Forms.Button();
            this.btnloginin = new System.Windows.Forms.Button();
            this.btncreatenewacc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtloginpage
            // 
            this.txtloginpage.AutoSize = true;
            this.txtloginpage.BackColor = System.Drawing.Color.Transparent;
            this.txtloginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginpage.ForeColor = System.Drawing.SystemColors.Info;
            this.txtloginpage.Location = new System.Drawing.Point(321, 58);
            this.txtloginpage.Name = "txtloginpage";
            this.txtloginpage.Size = new System.Drawing.Size(180, 35);
            this.txtloginpage.TabIndex = 0;
            this.txtloginpage.Text = "Login Page";
            this.txtloginpage.Click += new System.EventHandler(this.txtloginpage_Click);
            // 
            // writeusername
            // 
            this.writeusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.writeusername.Location = new System.Drawing.Point(385, 161);
            this.writeusername.Name = "writeusername";
            this.writeusername.Size = new System.Drawing.Size(100, 20);
            this.writeusername.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.AutoSize = true;
            this.txtusername.BackColor = System.Drawing.Color.Transparent;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(272, 161);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(93, 17);
            this.txtusername.TabIndex = 2;
            this.txtusername.Text = "User Name:";
            // 
            // txtpassword
            // 
            this.txtpassword.AutoSize = true;
            this.txtpassword.BackColor = System.Drawing.Color.Transparent;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(284, 201);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(81, 17);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Text = "password:";
            // 
            // writepassword
            // 
            this.writepassword.Location = new System.Drawing.Point(385, 201);
            this.writepassword.Name = "writepassword";
            this.writepassword.Size = new System.Drawing.Size(100, 20);
            this.writepassword.TabIndex = 4;
            // 
            // btnforgotpassword
            // 
            this.btnforgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.btnforgotpassword.Location = new System.Drawing.Point(246, 237);
            this.btnforgotpassword.Name = "btnforgotpassword";
            this.btnforgotpassword.Size = new System.Drawing.Size(148, 23);
            this.btnforgotpassword.TabIndex = 5;
            this.btnforgotpassword.Text = "Fortgot Password";
            this.btnforgotpassword.UseVisualStyleBackColor = false;
            // 
            // btnloginin
            // 
            this.btnloginin.BackColor = System.Drawing.Color.Transparent;
            this.btnloginin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginin.Location = new System.Drawing.Point(431, 236);
            this.btnloginin.Name = "btnloginin";
            this.btnloginin.Size = new System.Drawing.Size(75, 23);
            this.btnloginin.TabIndex = 6;
            this.btnloginin.Text = "Login In";
            this.btnloginin.UseVisualStyleBackColor = false;
            // 
            // btncreatenewacc
            // 
            this.btncreatenewacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatenewacc.Location = new System.Drawing.Point(306, 294);
            this.btncreatenewacc.Name = "btncreatenewacc";
            this.btncreatenewacc.Size = new System.Drawing.Size(179, 50);
            this.btncreatenewacc.TabIndex = 7;
            this.btncreatenewacc.Text = "Create New Account";
            this.btncreatenewacc.UseVisualStyleBackColor = true;
            this.btncreatenewacc.Click += new System.EventHandler(this.btncreatenewacc_Click);
            // 
            // loginpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.resigister_page_2;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.btncreatenewacc);
            this.Controls.Add(this.btnloginin);
            this.Controls.Add(this.btnforgotpassword);
            this.Controls.Add(this.writepassword);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.writeusername);
            this.Controls.Add(this.txtloginpage);
            this.Name = "loginpage";
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtloginpage;
        private System.Windows.Forms.TextBox writeusername;
        private System.Windows.Forms.Label txtusername;
        private System.Windows.Forms.Label txtpassword;
        private System.Windows.Forms.TextBox writepassword;
        private System.Windows.Forms.Button btnforgotpassword;
        private System.Windows.Forms.Button btnloginin;
        private System.Windows.Forms.Button btncreatenewacc;
    }
}

