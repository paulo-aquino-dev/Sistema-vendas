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
    public partial class telaAtCliente : Form
    {
        public telaAtCliente()
        {
            InitializeComponent();
        }
        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();

        public string idC;
        public string natureza;
        public string clas;

        private void btnCEP_Click(object sender, EventArgs e)
        {

            try
            {
                Correios.AtendeClienteClient cliente = new Correios.AtendeClienteClient();

                Correios.enderecoERP end = cliente.consultaCEP(mskCEP.Text);

                txtEndereco.Text = end.end;

                txtBairro.Text = end.bairro;

                txtCidade.Text = end.cidade;

                cmbEstado.Text = end.uf;
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado!!!");
                mskCEP.Text = "";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

                try
                {
                    string strSql = "update tbClientes set cliVendedor='" + cmbVend.SelectedItem.ToString() + "',";
                    strSql += "cliRazao='" + txtRazaoSocial.Text + "',";
                    strSql += "cliFantasia='" + txtNfantasia.Text + "',";
                    strSql += "cliEstadual='" + mskInsc.Text + "',";
                    strSql += "cliCNPJ='" + mskCNPJ.Text + "',";
                    strSql += "cliCPF='" + mskCPF.Text + "',";
                    strSql += "cliCEP='" + mskCEP.Text + "',";
                    strSql += "cliEstado='" + cmbEstado.SelectedItem.ToString() + "',";
                    strSql += "cliRua='" + txtEndereco.Text + "',";
                    strSql += "cliBairro='" + txtBairro.Text + "',";
                    strSql += "cliNumero='" + txtNum.Text + "',";
                    strSql += "cliContato='" + txtContato.Text + "',";
                    strSql += "cliRamo='" + txtRamoA.Text + "',";
                    strSql += "cliNatureza='" + clas + "',";
                    strSql += "cliEmail='" + txtEmail.Text + "',";
                    strSql += "cliCod='" + txtCod.Text + "',";
                    strSql += "cliCidade='" + txtCidade.Text + "',";
                    strSql += "cliSegemento='" + cmbSegmento.SelectedItem.ToString() + "'";

                    strSql += "where idCli = " + idC;


                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Dados Atualizados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show("Registro Inserido com Sucesso!!!", "Dados Cadastrados",
                    //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Visible = false;


                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Atualizar Dados!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
            
        private void telaAtCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //abrir banco
                objCnx.ConnectionString = "Server=192.168.1.201;Database=Portal;User=DBA;Pwd=facepr13;";

                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "Erro ao Conectar ao Banco de Dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbPres_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbTerceiro_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbUsuario_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void txtRamoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbTerceiro_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rdbUsu_CheckedChanged(object sender, EventArgs e)
        {
            clas = "6901";

            rdbRet.Checked = false;
            rdbRetFora.Checked = false;

        }

        private void rdbTer_CheckedChanged(object sender, EventArgs e)
        {
         
            clas = "5901";
            
            rdbRet.Checked = false;
            rdbRetFora.Checked = false;

        }

        private void rdbRet_CheckedChanged(object sender, EventArgs e)
        {
            clas = "5915";
            rdbInd1.Checked = false;
            rdbInd2.Checked = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbRetFora_CheckedChanged(object sender, EventArgs e)
        {
            clas = "6915";
            rdbInd1.Checked = false;
            rdbInd2.Checked = false;
        }
    }
}
