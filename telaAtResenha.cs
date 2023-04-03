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
    public partial class telaAtResenha : Form
    {
        public telaAtResenha()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }

        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objFunc;

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResenha.Text, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, 20, 20);
        }


        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        public string idR;
        
        public string upRes;


        private void telaAtResenha_Load(object sender, EventArgs e)
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {

                upRes += string.Format("{0}", Environment.NewLine); 

                upRes += dateTimePicker1.Value.ToLongDateString() + " - " + dateTimePicker1.Value.ToShortTimeString() + " : ";



                string strSql = "Update tbResenha set resResenha ='" +upRes+ txtResenha.Text + "'";
                strSql += "where idResenha = " + idR;


                //conexão com o comando
                objCmd.Connection = objCnx;
                //Atribui o comando
                objCmd.CommandText = strSql;
                //Executa a querry
                objCmd.ExecuteNonQuery();

            
                
                MessageBox.Show("Registro atualizado com Sucesso!!!", "Dados Cadastrados",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
               
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Cadastrar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void txtResenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
