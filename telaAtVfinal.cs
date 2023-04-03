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
    public partial class telaAtVfinal : Form
    {
        public telaAtVfinal()
        {
            InitializeComponent();
        }

        public string idV;
        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objFunc;

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try { 
            string strSql = "update tbvendas set venVendedor='" + cmbVendedor.SelectedItem.ToString() + "',";
            strSql += "venData='"+mskData.Text+ "',";
            strSql += "venVencimento='" + mskVencimento.Text+"',";
            strSql += "venNum='" + mskNum.Text + "',";
            strSql += "vencliente='" + txtEmpresa.Text + "',";
            strSql += "venComicao='" + txtComicao.Text + "',";
            strSql += "vennf='" + mskNf.Text + "',";
            strSql += "venValor='" + txtValor.Text + "'";
            strSql += "where idVen =" + idV;


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

        private void telaAtVfinal_Load(object sender, EventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
