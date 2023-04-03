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
    public partial class telaSplash : Form
    {
        public telaSplash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {

                pgbSplash.Value = pgbSplash.Value + 5;


                if (pgbSplash.Value <= 20)
                {
                    lblCarrega.Text = "Carregando.";
                    
                }
                else if (pgbSplash.Value <= 30)
                {
                    lblCarrega.Text = "Carregando..";
                    
                }
                else if (pgbSplash.Value <= 40)
                {
                    lblCarrega.Text = "Carregando...";
                    
                }
                else if (pgbSplash.Value <= 60)
                {
                    lblCarrega.Text = "Carregando";
                    
                }
                else if (pgbSplash.Value <= 70)
                {
                    lblCarrega.Text = "Carregando.";
                }
                else if (pgbSplash.Value <= 90)
                {
                    lblCarrega.Text = "Carregando..";
                }
                else if (pgbSplash.Value <= 100)
                {
                    lblCarrega.Text = "Carregando...";
                }

            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;

                telaMenuADM tma = new telaMenuADM();
                tma.Visible = true;
               


            }
        }

        private void telaSplash_Load(object sender, EventArgs e)
        {
          
        }
    }
}
