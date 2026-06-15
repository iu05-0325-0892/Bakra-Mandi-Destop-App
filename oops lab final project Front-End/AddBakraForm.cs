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
    public partial class AddBakraForm : Form
    {
        public string NewTitle { get; set; }
        public string NewPrice { get; set; }
        public string NewLocation { get; set; }
        public string NewTeeth { get; set; }
        public string NewWeight { get; set; }

        public AddBakraForm()
        {
            InitializeComponent();
        }

        private void AddBakraForm_Load(object sender, EventArgs e)
        {

        }

        private void btnaddbakra_Click(object sender, EventArgs e)
        {

            NewTitle = textBox1.Text;
            NewPrice = textBox2.Text;
            NewLocation = textBox3.Text;
            NewTeeth = textBox4.Text;
            NewWeight = textBox5.Text;

            
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
