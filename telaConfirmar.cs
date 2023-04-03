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
    public partial class telaConfirmar : Form
    {
        public telaConfirmar()
        {
            InitializeComponent();
        }

         public string idC;
        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataAdapter mAdapter1;
        private DataSet dat1;

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("EXCLUIR"))
            {
                textBox1.ForeColor = System.Drawing.Color.Green;
                label1.Text = "OK";
                label1.ForeColor = System.Drawing.Color.Green;
                button1.Enabled = true;

                try
                {


                    string strSql = "delete from tbclientes where idCli ='" + idC + "'";

                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro deletado com Sucesso!!!", "Dados Removidos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Close();
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao excluir!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
                label1.Text = "X";
                label1.ForeColor = System.Drawing.Color.Red;
                button1.Enabled = false;
            }
        }

        private void telaConfirmar_Load(object sender, EventArgs e)
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
            MessageBox.Show("DIGITE EXCLUIR PARA CONTINUAR!!!", "AVISO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

           
        }
    }
}
