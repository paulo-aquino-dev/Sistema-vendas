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
    public partial class telaProcesso : Form
    {
        public telaProcesso()
        {
            InitializeComponent();
        }

        public string idResenha;
        public string resenha;
        string res;
        Boolean vdd;

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataAdapter mAdapter1;
        private DataSet dat1;

        DataTable dt = new DataTable();
        ArrayList lista1 = new ArrayList();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < 100)
            {

                pgbSplash.Value = pgbSplash.Value + 5;


                if (pgbSplash.Value <= 20)
                {
                    lblCarrega.Text = "Verificando.";

                }
                else if (pgbSplash.Value <= 30)
                {
                    lblCarrega.Text = "Verificando..";

                }
                else if (pgbSplash.Value <= 40)
                {
                    lblCarrega.Text = "Verificando...";

                }
                else if (pgbSplash.Value <= 60)
                {
                    lblCarrega.Text = "Verificando";

                }
                else if (pgbSplash.Value <= 70)
                {
                    lblCarrega.Text = "Verificando.";
                }
                else if (pgbSplash.Value <= 90)
                {
                    lblCarrega.Text = "Verificando..";
                }
                else if (pgbSplash.Value <= 100)
                {
                    lblCarrega.Text = "Verificando...";
                }

            }
            else
            {
                timer1.Enabled = false;
                if (vdd == true)
                {
                    MessageBox.Show("Prospecção deletada", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {


                        string strSql = "Update tbPros set proVisivel = '0' where idpro = '" + idResenha + "'";

                        //conexão com o comando
                        objCmd.Connection = objCnx;
                        //Atribui o comando
                        objCmd.CommandText = strSql;
                        //Executa a querry
                        objCmd.ExecuteNonQuery();

                        MessageBox.Show("Registro deletado com Sucesso!!!", "Dados Removidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao deletar!!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else if (vdd == false)
                {
                    MessageBox.Show("POR FAVOR FAÇA UMA RESENHA ANTES DE DELETAR", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                this.Visible = false;

            }
        }

        private void telaProcesso_Load(object sender, EventArgs e)
        {
            //idResenha = "8";
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

            dat1 = new DataSet();
            mAdapter1 = new MySqlDataAdapter("select (resresenha) from tbresenha where idresenha = "+idResenha+";", objCnx);
            mAdapter1.Fill(dat1, "tbProspec");

            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
            {
                lista1.Add(dtrow1.ItemArray[0]);

                res = dtrow1.ItemArray[0].ToString();

                string t = DateTime.Now.Date.ToLongDateString();

                string palavras = res;

                if (palavras.Contains(t))
                {
                    Console.WriteLine("Existe!");
                    vdd = true;

                }
                else
                {
                    Console.WriteLine("Não existe!");
                    vdd = false;
                }

            }
            }
    }
}
