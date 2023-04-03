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
    public partial class telaCliente : Form
    {
        public telaCliente()
        {
            InitializeComponent();
        }

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();

        public string natureza;
        public string clas;

        string mes;

        private void rdbRet_CheckedChanged(object sender, EventArgs e)
        {
            clas = "5915";
            rdbInd1.Checked = false;
            rdbInd2.Checked = false;
        }

        private void rdbRetFora_CheckedChanged(object sender, EventArgs e)
        {
            clas = "6915";
            rdbInd1.Checked = false;
            rdbInd2.Checked = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void telaCliente_Load(object sender, EventArgs e)
        {
            mes = DateTime.Now.Month.ToString();

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

        private void rdbTerceiro_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdbUsuario_CheckedChanged(object sender, EventArgs e)
        {
           
        }

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
                    string strSql;

                    strSql = "INSERT INTO tbClientes(cliVendedor,cliRazao,cliFantasia,cliEstadual,cliCNPJ,cliCPF,cliCEP,cliEstado,cliRua,cliBairro,cliNumero,cliContato,cliRamo,cliNatureza,cliCod,cliCidade,cliSegemento,cliEmail,climes)VALUES(";

                    strSql += "'" + cmbVend.SelectedItem.ToString() + "',";
                    strSql += "'" + txtRazaoSocial.Text + "',";
                    strSql += "'" + txtNfantasia.Text + "',";
                    strSql += "'" + mskInsc.Text + "',";
                    strSql += "'" + mskCNPJ.Text + "',";
                    strSql += "'" + mskCPF.Text + "',";
                    strSql += "'" + mskCEP.Text + "',";
                    strSql += "'" + cmbEstado.SelectedItem.ToString() + "',";
                    strSql += "'" + txtEndereco.Text + "',";
                    strSql += "'" + txtBairro.Text + "',";
                    strSql += "'" + txtNum.Text + "',";
                    strSql += "'" + txtContato.Text + "',";
                    strSql += "'" + txtRamoA.Text + "',";
                    strSql += "'" + clas + "',";
                    strSql += "'" + txtCod.Text + "',";
                    strSql += "'" + txtCidade.Text + "',";
                    strSql += "'" + cmbSegmento.SelectedItem.ToString() + "',";
                    strSql += "'" + txtEmail.Text + "',";
                    strSql += "'" + mes + "')";
                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro Inserido com Sucesso!!!", "Dados Cadastrados",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Cadastrar Dados!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtNfantasia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbInd1_CheckedChanged(object sender, EventArgs e)
        {
            clas = "5901";

            rdbRet.Checked = false;
            rdbRetFora.Checked = false;
        }

        private void rdbInd2_CheckedChanged(object sender, EventArgs e)
        {
            clas = "6901";

            rdbRet.Checked = false;
            rdbRetFora.Checked = false;
        }
    }
}
