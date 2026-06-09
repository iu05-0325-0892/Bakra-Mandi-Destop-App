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
    public partial class inboxsidepanel : Form
    {
        public inboxsidepanel()
        {
            InitializeComponent();
        }


        private void inboxsidepanel_Load(object sender, EventArgs e)
        {

            lstChat.Items.Add("Muhammad Salman");
            lstChat.Items.Add("Abdullah (Seller)");
            lstChat.Items.Add("Sarah (Buyer)");
            lstChat.Items.Add("Support Admin");
        }

        private void inboxsidepanel_Load_1(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
            lstChat.Items.Add("Muhammad Salman");
            lstChat.Items.Add("Abdullah (Seller)");
            lstChat.Items.Add("Sarah (Buyer)");
            lstChat.Items.Add("Support Admin");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // 1. Check if the typing box is NOT empty (we don't want to send blank messages!)
            if (txtTyping.Text != "")
            {
                // 2. Add the text to the big chat window, with a "Me: " prefix so it looks like a chat app
                lstChat.Items.Add("Me: " + txtTyping.Text);

                // 3. Clear out the bottom typing box so it's ready for the next message
                txtTyping.Clear();
            }
        }

        private void panelchatbox_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
