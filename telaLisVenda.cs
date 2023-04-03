using System;
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
    public partial class telaLisVenda : Form
    {
        public telaLisVenda()
        {
            InitializeComponent();
        }

        public int vds;

        public int tru;

        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objFunc;
        private MySqlDataAdapter mAdapter;
        private DataSet dat;

        private void telaLisVenda_Load(object sender, EventArgs e)
        {
            if (tru.Equals(1))
            {
                restaurarToolStripMenuItem.Visible = false;
            }
            else if (tru.Equals(2))
            {
                deletarToolStripMenuItem.Visible = false;
            }
                

            try
            {
                dat = new DataSet();

                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

                objCnx.Open();

                if (objCnx.State == ConnectionState.Open)
                {
                    switch (tru)
                    {
                        case 1:

                    if (vds.Equals(1))
                    {
                        mAdapter = new MySqlDataAdapter("call pProspec1(1);", objCnx);

                        //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                        //preenche o dataset atravez do adapter
                        mAdapter.Fill(dat, "tbProspec");

                        //atribui os dados
                        dataGridView1.DataSource = dat;
                        dataGridView1.DataMember = "tbProspec";

                        dataGridView1.DataSource = dat.Tables["tbProspec"];
                    }

                    else if (vds.Equals(2))
                    {
                        mAdapter = new MySqlDataAdapter("call pProspec2(1);", objCnx);

                        //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                        //preenche o dataset atravez do adpter
                        mAdapter.Fill(dat, "tbProspec");

                        //atribui os dados
                        dataGridView1.DataSource = dat;
                        dataGridView1.DataMember = "tbProspec";

                        dataGridView1.DataSource = dat.Tables["tbProspec"];
                    }
                    else if (vds.Equals(3))
                    {
                        mAdapter = new MySqlDataAdapter("call pProspec3(1);", objCnx);

                        //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                        //preenche o dataset atravez do adpter
                        mAdapter.Fill(dat, "tbProspec");

                        //atribui os dados
                        dataGridView1.DataSource = dat;
                        dataGridView1.DataMember = "tbProspec";

                        dataGridView1.DataSource = dat.Tables["tbProspec"];
                    }
                    else if (vds.Equals(4))
                            {
                                mAdapter = new MySqlDataAdapter("call pProspec4(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            else if (vds.Equals(5))
                            {
                                mAdapter = new MySqlDataAdapter("select IDpro as ID, proNome as 'Empresa', proCategoria as 'Classificacao', prodiaretorno AS 'Retorno', proTelefone as'Telefone',proEmail as 'E-mail', proContato as 'Contato', proDepartamrnto as 'Departamento', proData as 'Data de Cadastro', proVendedor as 'Vendedor', proRamo 'Ramo de Atividade', proSegmento as 'Segemento', proCEp as 'CEP', proEstado as 'Estado', proBairro as bairro, proRua as 'Endereco', proNumero as 'Numero', tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'adm' and proVisivel = '1' order by prodiaretorno asc;", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            break;
                        case 0:
                            if (vds.Equals(1))
                            {
                                mAdapter = new MySqlDataAdapter("call pProspec01(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adapter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }

                            else if (vds.Equals(2))
                            {
                                mAdapter = new MySqlDataAdapter("call pProspec02(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            else if (vds.Equals(3))
                            {
                                mAdapter = new MySqlDataAdapter("call pProspec03(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            else if (vds.Equals(4))
                            {
                                mAdapter = new MySqlDataAdapter("call pProspec04(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            else if (vds.Equals(5))
                            {
                                mAdapter = new MySqlDataAdapter("select IDpro as ID, proNome as 'Empresa', proCategoria as 'Classificacao', prodiaretorno AS 'Retorno', proTelefone as'Telefone',proEmail as 'E-mail', proContato as 'Contato', proDepartamrnto as 'Departamento', proData as 'Data de Cadastro', proVendedor as 'Vendedor', proRamo 'Ramo de Atividade', proSegmento as 'Segemento', proCEp as 'CEP', proEstado as 'Estado', proBairro as bairro, proRua as 'Endereco', proNumero as 'Numero', tbresenha.idResenha as 'ID Resenha', tbResenha.resResenha as 'Resenha' from tbPros inner join tbResenha on tbResenha.idResenha = tbpros.idpro and tbpros.proVendedor = 'adm' and proVisivel = '0' order by prodiaretorno asc;", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbProspec");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbProspec";

                                dataGridView1.DataSource = dat.Tables["tbProspec"];
                            }
                            break;
                }

                }

            
                MessageBox.Show("Registro Listado com Sucesso!!!", "Dados Cadastrados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void atualizarProspecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            tav.idRes = dataGridView1.SelectedCells[17].Value.ToString();
            tav.res = dataGridView1.SelectedCells[18].Value.ToString();

            tav.ShowDialog();
        }

        private void atualizarResenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVisResenha tar = new telaVisResenha();

            this.Visible = false;
            tar.idRvis = dataGridView1.SelectedCells[17].Value.ToString();
            tar.visRes = dataGridView1.SelectedCells[18].Value.ToString();

            tar.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idV = dataGridView1.SelectedCells[0].Value.ToString();
            telaProcesso tp = new telaProcesso();

            
            tp.idResenha = dataGridView1.SelectedCells[17].Value.ToString();
            tp.ShowDialog();

            
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idV = dataGridView1.SelectedCells[0].Value.ToString();
            try
            {

               
                    string strSql = "Update tbPros set proVisivel = '1' where idpro = '" + idV + "'";

                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();
                    MessageBox.Show("Registro restaurado com Sucesso!!!", "Dados Restaurados",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao restaurar!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
