
namespace oops_lab_final_project_Front_End
{
    partial class inboxsidepanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.writesearchbox = new System.Windows.Forms.TextBox();
            this.txtchatbox = new System.Windows.Forms.Panel();
            this.panelchatboxtyping = new System.Windows.Forms.Panel();
            this.txtTyping = new System.Windows.Forms.TextBox();
            this.btnsendmsg = new System.Windows.Forms.Button();
            this.lstChat = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.txtchatbox.SuspendLayout();
            this.panelchatboxtyping.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstChat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.writesearchbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::oops_lab_final_project_Front_End.Properties.Resources.search_box_png;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 38);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // writesearchbox
            // 
            this.writesearchbox.Location = new System.Drawing.Point(0, 21);
            this.writesearchbox.Multiline = true;
            this.writesearchbox.Name = "writesearchbox";
            this.writesearchbox.Size = new System.Drawing.Size(200, 34);
            this.writesearchbox.TabIndex = 0;
            // 
            // txtchatbox
            // 
            this.txtchatbox.Controls.Add(this.panelchatboxtyping);
            this.txtchatbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtchatbox.Location = new System.Drawing.Point(200, 0);
            this.txtchatbox.Name = "txtchatbox";
            this.txtchatbox.Size = new System.Drawing.Size(373, 450);
            this.txtchatbox.TabIndex = 1;
            this.txtchatbox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchatbox_Paint);
            // 
            // panelchatboxtyping
            // 
            this.panelchatboxtyping.Controls.Add(this.txtTyping);
            this.panelchatboxtyping.Controls.Add(this.btnsendmsg);
            this.panelchatboxtyping.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelchatboxtyping.Location = new System.Drawing.Point(0, 406);
            this.panelchatboxtyping.Name = "panelchatboxtyping";
            this.panelchatboxtyping.Size = new System.Drawing.Size(373, 44);
            this.panelchatboxtyping.TabIndex = 0;
            // 
            // txtTyping
            // 
            this.txtTyping.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTyping.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.Location = new System.Drawing.Point(0, 0);
            this.txtTyping.Multiline = true;
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(327, 44);
            this.txtTyping.TabIndex = 2;
            this.txtTyping.Text = "Type Here";
            // 
            // btnsendmsg
            // 
            this.btnsendmsg.BackColor = System.Drawing.Color.DarkRed;
            this.btnsendmsg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsendmsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnsendmsg.ForeColor = System.Drawing.Color.Azure;
            this.btnsendmsg.Location = new System.Drawing.Point(323, 0);
            this.btnsendmsg.Name = "btnsendmsg";
            this.btnsendmsg.Size = new System.Drawing.Size(50, 44);
            this.btnsendmsg.TabIndex = 1;
            this.btnsendmsg.Text = "Send";
            this.btnsendmsg.UseVisualStyleBackColor = false;
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.Location = new System.Drawing.Point(4, 53);
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(196, 407);
            this.lstChat.TabIndex = 2;
            // 
            // inboxsidepanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.txtchatbox);
            this.Controls.Add(this.panel1);
            this.Name = "inboxsidepanel";
            this.Text = "inboxsidepanel";
            this.Load += new System.EventHandler(this.inboxsidepanel_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.txtchatbox.ResumeLayout(false);
            this.panelchatboxtyping.ResumeLayout(false);
            this.panelchatboxtyping.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox writesearchbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel txtchatbox;
        private System.Windows.Forms.Panel panelchatboxtyping;
        private System.Windows.Forms.Button btnsendmsg;
        private System.Windows.Forms.TextBox txtTyping;
        private System.Windows.Forms.ListBox lstChat;
    }
}