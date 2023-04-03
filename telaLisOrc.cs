using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Russo2
{
    public partial class telaLisOrc : Form
    {
        public telaLisOrc()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        public int vds;

        string impressao;

        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        private MySqlDataReader objFunc;
        private MySqlDataAdapter mAdapter;
        private DataSet dat;

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(impressao, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, 20, 20);
        }


        private void telaLisOrc_Load(object sender, EventArgs e)
        {
            dat = new DataSet();

            objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

            objCnx.Open();

            if (objCnx.State == ConnectionState.Open)
            {
                try
                {
                    
                        mAdapter = new MySqlDataAdapter("call pVendas(1);", objCnx);

                        //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                        //preenche o dataset atravez do adpter
                        mAdapter.Fill(dat, "tbVendas");

                        //atribui os dados
                        dataGridView1.DataSource = dat;
                        dataGridView1.DataMember = "tbVendas";

                        dataGridView1.DataSource = dat.Tables["tbVendas"];
                        MessageBox.Show("Registro Listado com Sucesso!!!", "Dados listados",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }


                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dat = new DataSet();
            try
            {
                mAdapter = new MySqlDataAdapter("select idven as ID, venCliente as Cliente, venVendedor as Vendedor,venmes as Mes, venNF as Nota,venvalor as Valor,vencomicao as Comicao,venData as Emissao, venVencimento as vencimento,venNum as Numero from tbvendas where tbvendas.venvendedor ='" + cmbVendedor.SelectedItem.ToString() + "' and venmes = '" + cmbMes.SelectedItem.ToString() + "';", objCnx);

                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                //preenche o dataset atravez do adpter
                mAdapter.Fill(dat, "tbVendas");

                //atribui os dados
                dataGridView1.DataSource = dat;
                dataGridView1.DataMember = "tbVendas";

                dataGridView1.DataSource = dat.Tables["tbVendas"];
                MessageBox.Show("Registro Listado com Sucesso!!!", "Dados listados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAtVfinal taf = new telaAtVfinal();
            this.Visible = false;
            taf.idV = dataGridView1.SelectedCells[0].Value.ToString();
            taf.txtEmpresa.Text = dataGridView1.SelectedCells[1].Value.ToString();
            taf.cmbVendedor.Text = dataGridView1.SelectedCells[2].Value.ToString();
            //taf. o mes 3 
            taf.mskNf.Text = dataGridView1.SelectedCells[4].Value.ToString();
            taf.txtValor.Text = dataGridView1.SelectedCells[5].Value.ToString();
            taf.txtComicao.Text = dataGridView1.SelectedCells[6].Value.ToString();
            taf.mskData.Text = dataGridView1.SelectedCells[7].Value.ToString();
            taf.mskVencimento.Text = dataGridView1.SelectedCells[8].Value.ToString();
            taf.mskNum.Text = dataGridView1.SelectedCells[9].Value.ToString();

            taf.ShowDialog();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //impressao = dataGridView1.SelectAll();
            impressao += dataGridView1.SelectedCells[1].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[2].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[3].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[5].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[6].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[7].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[8].Value.ToString() + " ";
            impressao += dataGridView1.SelectedCells[9].Value.ToString() + " ";

            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }
    }
}
