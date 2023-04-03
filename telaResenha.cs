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
    public partial class telaResenha : Form
    {
        public telaResenha()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }
        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();

        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResenha.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 20, 20);
        }


        private void txtResenha_TextChanged(object sender, EventArgs e)
        {

        }
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        private void verifica()
        {
            
                if (txtResenha.TextLength < 1)
                {
                    MessageBox.Show("Por favor faça um resumo da proposta!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
            {

                try
                {
                    string strSql;
                    
                    //string data = string.Format("{0}", Environment.NewLine); ;

                    string data = dateTimePicker1.Value.ToLongDateString() +" - "+dateTimePicker1.Value.ToShortTimeString() +" : ";
                    
                    

                    strSql = "INSERT INTO tbResenha(resResenha)VALUE(";
                    strSql += "'"+data +txtResenha.Text + "')";


                    //conexão com o comando
                    objCmd.Connection = objCnx;
                    //Atribui o comando
                    objCmd.CommandText = strSql;
                    //Executa a querry
                    objCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro Inserido com Sucesso!!!", "Dados Cadastrados",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Cadastrar Dados!!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
           
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
           
                verifica();    
        }

        private void telaResenha_Load(object sender, EventArgs e)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }
    }
}
