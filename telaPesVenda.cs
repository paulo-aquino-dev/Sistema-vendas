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

namespace Russo2
{
    public partial class telaPesVenda : Form
    {
        public telaPesVenda()
        {
            InitializeComponent();
        }

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataAdapter mAdapter;

        private DataSet dat;

        public int vds;

        public bool sgmt;

        private void telaPesVenda_Load(object sender, EventArgs e)
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

        private void btnBusca_Click(object sender, EventArgs e)
        {
            dat = new DataSet();

            if (objCnx.State == ConnectionState.Open)
            {
                try
                {

                    if (vds.Equals(1))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and not tbpros.proVendedor = 'vendas2' and proVisivel = '1' where proNome like '" + txtBusca.Text + "%'", objCnx);//+" or cliRazao like '" + txtBusca.Text +"%'"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        //select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',DATE_FORMAT(prodiaretorno, "%d/%m/%Y" ) AS 'Retorno',proTelefone as'Telefone',
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        // proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas1'
                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Pros");

                        dataGridView1.DataSource = ds.Tables["Pros"];
                    }
                    else if (vds.Equals(2))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and not tbpros.proVendedor = 'vendas1' where proNome like '" + txtBusca.Text + "%'", objCnx);
                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Pros");

                        dataGridView1.DataSource = ds.Tables["Pros"];
                    }
                    else if (vds.Equals(3))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro where proNome like '" + txtBusca.Text + "%'", objCnx);//+" or cliRazao like '" + txtBusca.Text +"%'"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Pros");

                        dataGridView1.DataSource = ds.Tables["Pros"];

                        
                    }
                    else if (vds.Equals(5))
                    {
                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and not tbpros.proVendedor = 'adm' where proNome like '" + txtBusca.Text + "%'", objCnx);

                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Pros");

                        dataGridView1.DataSource = ds.Tables["Pros"];


                    }
                    if (sgmt.Equals(true))
                    {
                        if (cmbSeg.Text.Equals("Segmento"))
                        {
                            MessageBox.Show("Erro escolha um segmento para buscar!!!", " Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MySqlDataAdapter mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro where proNome like '" + txtBusca.Text + "%' and proSegmento = '" + cmbSeg.Text+"'", objCnx);//+" or cliRazao like '" + txtBusca.Text +"%'"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     //select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',DATE_FORMAT(prodiaretorno, "%d/%m/%Y" ) AS 'Retorno',proTelefone as'Telefone',
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     // proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas1'
                        DataSet ds = new DataSet();

                        mAdapter.Fill(ds, "Pros");

                        dataGridView1.DataSource = ds.Tables["Pros"];

                        
                    }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Erro ==> " + Erro.Message, " Erro ao Buscar Dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void alterarProspecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            telaAtVenda tav = new telaAtVenda();
            this.Visible = false;
            tav.id = dataGridView1.SelectedCells[0].Value.ToString();
            tav.txtEmpresa.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tav.categoria = dataGridView1.SelectedCells[2].Value.ToString();
           // tav.diaRet = dataGridView1.SelectedCells[3].Value.ToString();
            tav.mskTel.Text = dataGridView1.SelectedCells[3].Value.ToString();
            tav.txtEmail.Text = dataGridView1.SelectedCells[4].Value.ToString();
            tav.txtResponsavel.Text = dataGridView1.SelectedCells[5].Value.ToString();
            tav.txtDepartamento.Text = dataGridView1.SelectedCells[6].Value.ToString();
            tav.txtDta.Text = dataGridView1.SelectedCells[7].Value.ToString();
            tav.txtRamo.Text = dataGridView1.SelectedCells[9].Value.ToString();
            tav.cmb1.Text = dataGridView1.SelectedCells[10].Value.ToString();
            tav.mskCEP.Text = dataGridView1.SelectedCells[11].Value.ToString();
            tav.cmbEstado.Text = dataGridView1.SelectedCells[12].Value.ToString();
            tav.txtBairro.Text = dataGridView1.SelectedCells[13].Value.ToString();
            tav.txtEndereco.Text = dataGridView1.SelectedCells[14].Value.ToString();
            tav.txtNum.Text = dataGridView1.SelectedCells[15].Value.ToString();

            tav.ShowDialog();
        }

        private void alterarResenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVisResenha tar = new telaVisResenha();

            this.Visible = false;
            tar.idRvis = dataGridView1.SelectedCells[16].Value.ToString();
            tar.visRes = dataGridView1.SelectedCells[17].Value.ToString();

            tar.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
