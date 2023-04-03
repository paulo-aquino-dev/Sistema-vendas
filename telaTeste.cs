using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russo2
{
    public partial class telaTeste : Form
    {
        public telaTeste()
        {
            InitializeComponent();
        }
        string t;

        private void telaTeste_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Red;






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("EXCLUIR"))
            {
                textBox1.ForeColor = System.Drawing.Color.Green;
                label1.Text = "OK";
                label1.ForeColor = System.Drawing.Color.Green;
                button1.Enabled = true;
            }
            else
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "X";
                label1.ForeColor = System.Drawing.Color.Red;
                button1.Enabled = false;
            }
        }
    }
}
