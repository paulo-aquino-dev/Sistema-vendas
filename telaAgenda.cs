using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Russo2
{
    public partial class telaAgenda : Form
    {
        public telaAgenda()
        {
            InitializeComponent();
        }

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();


        string dtaa;
        private MySqlDataAdapter mAdapter;
        private MySqlDataAdapter mAdapter2;
        private MySqlDataAdapter mAdapter3;

        private DataSet dat;
        private DataSet dat2;
        private DataSet dat3;

        string dataR;
        public int agd;
        ArrayList lista = new ArrayList();

        private void telaAgenda_Load(object sender, EventArgs e)
        {
            dtaa = DateTime.Now.Day.ToString() + "/";
            dtaa += DateTime.Now.Month.ToString() + "/";
            dtaa += DateTime.Now.Year.ToString();

            textBox1.Text = dtaa;

            agd = 1;
            try
            {
                 
                
                dat = new DataSet();
                dat2 = new DataSet();

                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

                objCnx.Open();
                
                                if (objCnx.State == ConnectionState.Open)
                                {
                                    //cria um adpter utilizando SQL para mostrar os dados
                                    if(agd.Equals(1))
                                    {
                                        mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas1' and proVisivel = '1' where prodiaretorno = '" + dtaa + "' order by prodiaretorno asc ;", objCnx);

                    }
                                    else if (agd.Equals(2))
                                    {
                                        mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas2' and proVisivel = '1' where prodiaretorno = '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    }
                                    else if (agd.Equals(3))
                                    {
                                        mAdapter = new MySqlDataAdapter("select IDpro as ID, proNome as 'Empresa', proCategoria as 'Classificacao', prodiaretorno AS 'Retorno', proTelefone as'Telefone', proEmail as 'E-mail', proContato as 'Contato', proDepartamrnto as 'Departamento', proData as 'Data de Cadastro', proVendedor as 'Vendedor', proRamo 'Ramo de Atividade', proSegmento as 'Segemento', proCEp as 'CEP', proEstado as 'Estado', proBairro as bairro, proRua as 'Endereco', proNumero as 'Numero', tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas3' and proVisivel = '1' where prodiaretorno = '" + dtaa + "' order by prodiaretorno asc ; ", objCnx);
                                    }
                                    else if (agd.Equals(4))
                                    {
                                        mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas4' and proVisivel = '1' where prodiaretorno = '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    }
                    else if (agd.Equals(5))
                    {
                        mAdapter = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'adm' and proVisivel = '1' where prodiaretorno = '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    }
                    //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                    //preenche o dataset atravez do adpter
                    mAdapter.Fill(dat, "tbPros");

                                    //atribui os dados
                                    dataGridView1.DataSource = dat;
                                    dataGridView1.DataMember = "tbPros";

                                    dataGridView1.DataSource = dat.Tables["tbPros"];
                                }

                if (agd.Equals(1))
                {
                    mAdapter2 = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas1' and proVisivel = '1' where prodiaretorno <= '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    mAdapter2.Fill(dat2, "tbPros");
                }
                else if (agd.Equals(2))
                {
                    mAdapter2 = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas2' and proVisivel = '1' where prodiaretorno <= '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    mAdapter2.Fill(dat2, "tbPros");
                }
               else  if (agd.Equals(3))
                {
                    mAdapter2 = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas3' and proVisivel = '1' where prodiaretorno <= '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    mAdapter2.Fill(dat2, "tbPros");
                }
                else if (agd.Equals(4))
                {
                    mAdapter2 = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'vendas4' and proVisivel = '1' where prodiaretorno <= '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    mAdapter2.Fill(dat2, "tbPros");
                }
                else if (agd.Equals(5))
                {
                    mAdapter2 = new MySqlDataAdapter("select IDpro as ID,proNome as 'Empresa' ,proCategoria as 'Classificacao',prodiaretorno AS 'Retorno',proTelefone as'Telefone',proEmail as 'E-mail',proContato as 'Contato',proDepartamrnto as 'Departamento',proData as 'Data de Cadastro',proVendedor as 'Vendedor',proRamo 'Ramo de Atividade',proSegmento as 'Segemento', proCEp as 'CEP',proEstado as 'Estado',proBairro as bairro,proRua as 'Endereco',proNumero as 'Numero' ,tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'adm' and proVisivel = '1' where prodiaretorno <= '" + dtaa + "' order by prodiaretorno asc ;", objCnx);
                    mAdapter2.Fill(dat2, "tbPros");
                }

                //atribui os dados
                dataGridView2.DataSource = dat2;
                dataGridView2.DataMember = "tbPros";

                dataGridView2.DataSource = dat2.Tables["tbPros"];


                MessageBox.Show("Registro Listado com Sucesso!!!", "Dados Cadastrados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //altCli.id = dataGridView1.SelectedCells[0].Value.ToString();
            //altCli.txtNome.Text = dataGridView1.SelectedCells[1].Value.ToString();
            telaAtVenda tav = new telaAtVenda();
            this.Visible = false;

            tav.id = dataGridView1.SelectedCells[0].Value.ToString();
            tav.txtEmpresa.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tav.categoria = dataGridView1.SelectedCells[2].Value.ToString();
            tav.diaRet = dataGridView1.SelectedCells[3].Value.ToString();
            tav.mskTel.Text = dataGridView1.SelectedCells[4].Value.ToString();
            tav.txtEmail.Text = dataGridView1.SelectedCells[5].Value.ToString();
            tav.txtResponsavel.Text = dataGridView1.SelectedCells[6].Value.ToString();
            tav.txtDepartamento.Text = dataGridView1.SelectedCells[7].Value.ToString();
            tav.txtDta.Text = dataGridView1.SelectedCells[8].Value.ToString();
            tav.txtRamo.Text = dataGridView1.SelectedCells[10].Value.ToString();
            tav.cmb1.Text = dataGridView1.SelectedCells[11].Value.ToString();
            tav.mskCEP.Text = dataGridView1.SelectedCells[12].Value.ToString();
            tav.cmbEstado.Text = dataGridView1.SelectedCells[13].Value.ToString();
            tav.txtBairro.Text = dataGridView1.SelectedCells[14].Value.ToString();
            tav.txtEndereco.Text = dataGridView1.SelectedCells[15].Value.ToString();
            tav.txtNum.Text = dataGridView1.SelectedCells[16].Value.ToString();

            tav.ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void alterarResenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVisResenha tar = new telaVisResenha();

            this.Visible = false;
            tar.idRvis = dataGridView1.SelectedCells[17].Value.ToString();
            tar.visRes = dataGridView1.SelectedCells[18].Value.ToString();

            tar.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alterarProspecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //altCli.id = dataGridView1.SelectedCells[0].Value.ToString();
            //altCli.txtNome.Text = dataGridView1.SelectedCells[1].Value.ToString();
            telaAtVenda tav = new telaAtVenda();
            this.Visible = false;

            tav.id = dataGridView2.SelectedCells[0].Value.ToString();
            tav.txtEmpresa.Text = dataGridView2.SelectedCells[1].Value.ToString();
            tav.categoria = dataGridView2.SelectedCells[2].Value.ToString();
            tav.diaRet = dataGridView2.SelectedCells[3].Value.ToString();
            tav.mskTel.Text = dataGridView2.SelectedCells[4].Value.ToString();
            tav.txtEmail.Text = dataGridView2.SelectedCells[5].Value.ToString();
            tav.txtResponsavel.Text = dataGridView2.SelectedCells[6].Value.ToString();
            tav.txtDepartamento.Text = dataGridView2.SelectedCells[7].Value.ToString();
            tav.txtDta.Text = dataGridView2.SelectedCells[8].Value.ToString();
            tav.txtRamo.Text = dataGridView2.SelectedCells[10].Value.ToString();
            tav.cmb1.Text = dataGridView2.SelectedCells[11].Value.ToString();
            tav.mskCEP.Text = dataGridView2.SelectedCells[12].Value.ToString();
            tav.cmbEstado.Text = dataGridView2.SelectedCells[13].Value.ToString();
            tav.txtBairro.Text = dataGridView2.SelectedCells[14].Value.ToString();
            tav.txtEndereco.Text = dataGridView2.SelectedCells[15].Value.ToString();
            tav.txtNum.Text = dataGridView2.SelectedCells[16].Value.ToString();

            tav.ShowDialog();
        }

        private void visualizarResenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVisResenha tar = new telaVisResenha();

            this.Visible = false;
            tar.idRvis = dataGridView2.SelectedCells[17].Value.ToString();
            tar.visRes = dataGridView2.SelectedCells[18].Value.ToString();

            tar.ShowDialog();
        }

        private void deletarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            telaProcesso tp = new telaProcesso();


            tp.idResenha = dataGridView2.SelectedCells[17].Value.ToString();
            tp.ShowDialog();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            telaProcesso tp = new telaProcesso();


            tp.idResenha = dataGridView1.SelectedCells[17].Value.ToString();
            tp.ShowDialog();
        }
    }
}
