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
    public partial class telaLisCliente : Form
    {
        public telaLisCliente()
        {
            InitializeComponent();
        }

        public int vds;
        public int tru;

        
        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objFunc;

        private MySqlDataAdapter mAdapter;
        private DataSet dat;

        private void telaLisCliente_Load(object sender, EventArgs e)
        {
            
            

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
                                mAdapter = new MySqlDataAdapter("call pClientes1(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(2))
                            {
                                mAdapter = new MySqlDataAdapter("call pClientes2(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(3))
                            {
                                mAdapter = new MySqlDataAdapter("call pClientes(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(5))
                            {
                                mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliRamo as Ramo,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,cliEmail as 'Email',CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro Bairro,cliRua as Rua,cliNumero as Numero,clisegemento as Segmento from tbClientes where clivendedor = 'adm'and clivis = '1';", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];


                            }


                            break;
                        case 0:
                            et.Visible = true;
                            rt.Visible = true;
                            dt.Visible = false;
                            if (vds.Equals(1))
                            {
                                mAdapter = new MySqlDataAdapter("call pClientes01(1);", objCnx);
                                

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(2))
                            {
                                mAdapter = new MySqlDataAdapter("call pClientes02(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(3))
                            {
                                mAdapter = new MySqlDataAdapter("call pClientes0(1);", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];
                            }
                            else if (vds.Equals(5))
                            {
                                mAdapter = new MySqlDataAdapter("select idCli as ID, cliFantasia as 'Nome Fantasia',cliRazao as Razao ,cliCod as Codigo,cliVendedor as Vendedor,cliContato as Contato,cliRamo as Ramo,cliEstadual as 'Inscricao estadual',cliCNPJ as CNPJ,clicpf as CPF,cliNatureza as Natureza,cliEmail as 'Email',CLIcep AS CEP,cliEstado as Estado,cliCidade as Cidade,cliBairro Bairro,cliRua as Rua,cliNumero as Numero,clisegemento as Segmento from tbClientes where clivendedor = 'adm' and clivis = '0';", objCnx);

                                //select cliemail as 'email',clinome as 'nome' from tbcliente ;
                                //preenche o dataset atravez do adpter
                                mAdapter.Fill(dat, "tbClientes");

                                //atribui os dados
                                dataGridView1.DataSource = dat;
                                dataGridView1.DataMember = "tbClientes";

                                dataGridView1.DataSource = dat.Tables["tbClientes"];

                            }
                            break;
                    }
    
                            MessageBox.Show("Registro Listado com Sucesso!!!", "Dados Listados",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                         
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void atualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //altCli.id = dataGridView1.SelectedCells[0].Value.ToString();
            //altCli.txtNome.Text = dataGridView1.SelectedCells[1].Value.ToString();
            telaAtCliente tac = new telaAtCliente();
            this.Visible = false;

            tac.idC = dataGridView1.SelectedCells[0].Value.ToString();
            tac.txtNfantasia.Text = dataGridView1.SelectedCells[1].Value.ToString();
            tac.txtRazaoSocial.Text = dataGridView1.SelectedCells[2].Value.ToString();
            tac.txtCod.Text = dataGridView1.SelectedCells[3].Value.ToString();
            tac.cmbVend.Text = dataGridView1.SelectedCells[4].Value.ToString();
            tac.txtContato.Text = dataGridView1.SelectedCells[5].Value.ToString();
            tac.mskInsc.Text = dataGridView1.SelectedCells[7].Value.ToString();
            tac.mskCNPJ.Text = dataGridView1.SelectedCells[8].Value.ToString();
            tac.mskCPF.Text = dataGridView1.SelectedCells[9].Value.ToString();
            //tac.natureza = dataGridView1.SelectedCells[9].Value.ToString();
            tac.txtEmail.Text = dataGridView1.SelectedCells[11].Value.ToString();
            tac.mskCEP.Text = dataGridView1.SelectedCells[12].Value.ToString();
            tac.cmbEstado.Text = dataGridView1.SelectedCells[13].Value.ToString(); 
            tac.txtCidade.Text = dataGridView1.SelectedCells[14].Value.ToString();
            tac.txtBairro.Text = dataGridView1.SelectedCells[15].Value.ToString();
            tac.txtEndereco.Text = dataGridView1.SelectedCells[16].Value.ToString();
            tac.txtNum.Text =  dataGridView1.SelectedCells[17].Value.ToString();
            tac.txtRamoA.Text = dataGridView1.SelectedCells[6].Value.ToString();

            tac.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idC = dataGridView1.SelectedCells[0].Value.ToString();


            if (MessageBox.Show("Tem certeza que deseja deletar esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    string strSql = "update tbclientes set cliVis = '0' where idcli = '" + idC + "'";

                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro deletado!!!", "!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Deletar!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idC = dataGridView1.SelectedCells[0].Value.ToString();


            if (MessageBox.Show("Tem certeza que deseja restaurar esse cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try
                {
                    string strSql = "update tbclientes set cliVis = '1' where idcli = '" + idC + "'";

                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro restaurado!!!", "!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Restaurar!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            telaConfirmar tc = new telaConfirmar();


            tc.idC = dataGridView1.SelectedCells[0].Value.ToString();
            tc.ShowDialog();
        }
    }
}
