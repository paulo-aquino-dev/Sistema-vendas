using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGV2Printer;

namespace Russo2
{
    public partial class telaPesCliente : Form
    {
        public telaPesCliente()
        {
            InitializeComponent();
        }

        public int vds;
        public bool sgmt;

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataAdapter mAdapter;
        private DataSet dat;

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dat = new DataSet();

            if (objCnx.State == ConnectionState.Open)
            {
                try
                {
                    if (vds.Equals(1))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro as Bairro,cliRua as Rua,cliNumero as Numero,cliRamo as ramo, cliEmail as Email,clisegemento as segmento from tbClientes where not clivendedor = 'vendas2'and (cliFantasia LIKE '" + txtBusca.Text + "%'" + " or cliRazao like '" + txtBusca.Text + "%' and clivis = '1')", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Clientes");

                        dataGridView1.DataSource = ds.Tables["Clientes"];
                    }
                    else if (vds.Equals(2))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro as Bairro,cliRua as Rua,cliNumero as Numero,cliRamo as ramo, cliEmail as Email,clisegemento as segmento from tbClientes where not clivendedor = 'vendas1'and (cliFantasia LIKE '" + txtBusca.Text + "%'" + " or cliRazao like '" + txtBusca.Text + "%'and clivis = '1')", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Clientes");

                        dataGridView1.DataSource = ds.Tables["Clientes"];
                    }
                    else if (vds.Equals(3))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro as Bairro,cliRua as Rua,cliNumero as Numero,cliRamo as ramo, cliEmail as Email,clisegemento as segmento from tbClientes where (cliFantasia LIKE '" + txtBusca.Text + "%'" + " or cliRazao like '" + txtBusca.Text + "%'and clivis = '1')", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Clientes");

                        dataGridView1.DataSource = ds.Tables["Clientes"];
                    }
                    else if (vds.Equals(5))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro as Bairro,cliRua as Rua,cliNumero as Numero,cliRamo as ramo, cliEmail as Email,clisegemento as segmento from tbClientes where not clivendedor = 'adm'and (cliFantasia LIKE '" + txtBusca.Text + "%'" + " or cliRazao like '" + txtBusca.Text + "%'and clivis = '1')", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Clientes");

                        dataGridView1.DataSource = ds.Tables["Clientes"];
                    }
                    else
                    {

                    }

                    if (sgmt.Equals(true))
                    {
                        if (cmbSeg.Text.Equals("Segmento"))
                        {
                            MessageBox.Show("Erro escolha um segmento para buscar!!!", " Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro as Bairro,cliRua as Rua,cliNumero as Numero,cliRamo as Ramo,cliEmail as Email  from tbClientes where(cliFantasia LIKE '" + txtBusca.Text + "%'" + " or cliRazao like '" + txtBusca.Text + "%' and cliSegemento = '" + cmbSeg.Text + "'and clivis = '1')", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Clientes");

                        dataGridView1.DataSource = ds.Tables["Clientes"];



                    }

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ==> " + Erro.Message, " Erro ao Buscar Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            }

            private void telaPesCliente_Load(object sender, EventArgs e)
        {
            if (sgmt.Equals(true))
            {
                cmbSeg.Visible = true;
            }

            try
            {
                dat = new DataSet();

                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

                objCnx.Open();
            }

            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void alterarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAtCliente tac = new telaAtCliente();
            this.Visible = false;

            tac.idC = dataGridView1.SelectedCells[0].Value.ToString();
            tac.txtNfantasia.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tac.txtRazaoSocial.Text = dataGridView1.SelectedCells[2].Value.ToString();
            tac.txtCod.Text = dataGridView1.SelectedCells[3].Value.ToString();
            tac.cmbVend.Text = dataGridView1.SelectedCells[4].Value.ToString();
            tac.txtContato.Text = dataGridView1.SelectedCells[5].Value.ToString();
            tac.mskInsc.Text = dataGridView1.SelectedCells[6].Value.ToString();
            tac.mskCNPJ.Text = dataGridView1.SelectedCells[7].Value.ToString();
            tac.mskCPF.Text = dataGridView1.SelectedCells[8].Value.ToString();
            //tac.natureza = dataGridView1.SelectedCells[9].Value.ToString();
            tac.txtEmail.Text = dataGridView1.SelectedCells[17].Value.ToString();
            tac.mskCEP.Text = dataGridView1.SelectedCells[10].Value.ToString();
            tac.cmbEstado.Text = dataGridView1.SelectedCells[11].Value.ToString();
            tac.txtCidade.Text = dataGridView1.SelectedCells[12].Value.ToString();
            tac.txtBairro.Text = dataGridView1.SelectedCells[13].Value.ToString();
            tac.txtEndereco.Text = dataGridView1.SelectedCells[14].Value.ToString();
            tac.txtNum.Text = dataGridView1.SelectedCells[15].Value.ToString();
            tac.txtRamoA.Text = dataGridView1.SelectedCells[16].Value.ToString();
            tac.cmbSegmento.Text = dataGridView1.SelectedCells[18].Value.ToString();

            tac.ShowDialog();

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }

        private void salvarImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintDataGridView pr = new PrintDataGridView(dataGridView1);
            //pr.isRightToLeft = false;
            //pr.ReportHeader = "This is top of page...";
            //pr.ReportFooter = "This is Report Footer ...";
            //pr.Print();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
