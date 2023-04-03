using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russo2
{
    public partial class telaVfinal : Form
    {
        public telaVfinal()
        {
            InitializeComponent();
        }
        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objFunc;

        private MySqlDataAdapter mAdapter;
        private MySqlDataAdapter mAdapter1;
        private DataSet dat;
        private DataSet dat1;

        DataTable dt = new DataTable();

        ArrayList lista1 = new ArrayList();

        string mes;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {

            string t = txtValor.Text;
            if (t != "")
            {
                decimal valor = Convert.ToDecimal(t);
            }
            
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.Text = "";
            //toolTip1.Show("Mantenha nesse formato 1000.00", txtValor);
        }

        private void mskcomicao_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            string t1 = txtComicao.Text;
            if (t1 != "")
            {
                decimal valor1 = Convert.ToDecimal(t1);
                string t2 = txtValor.Text;
                int v2 = Convert.ToInt32(t2);
                int v1 = Convert.ToInt32(t1);

                if (v1>v2)
                {
                    MessageBox.Show("Comição não pode ser maior do que o valor", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtValor.Text = "";
                    txtComicao.Text = "";
                }
            }

          
        }

        private void txtComicao_Enter(object sender, EventArgs e)
        {
            txtComicao.Text = "";
            //toolTip1.Show("Mantenha nesse formato 1000.00", txtComicao);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        { 
                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }
            
        }

        private void txtComicao_KeyPress(object sender, KeyPressEventArgs e)
        {

                if (!char.IsDigit(e.KeyChar))

                {

                    e.Handled = true;

                }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string strSql = "INSERT INTO tbVendas (venCliente,venData,venNum,venVencimento,venVendedor,venComicao,venNF,venValor,venmes) VALUES (";
                strSql += "'" + txtEmpresa.Text + "',";
                strSql += "'" + mskData.Text + "',";
                strSql += "'" + mskNum.Text + "',";
                strSql += "'" + mskVencimento.Text + "',";
                strSql += "'" + cmbVendedor.SelectedItem.ToString() + "',";
                strSql += "'" + txtComicao.Text + "',";
                strSql += "'" + mskNf.Text + "',";
                strSql += "'" + txtValor.Text + "',";
                strSql += "'" + mes + "')";

                //conexão com o comando
                objCmd.Connection = objCnx;
                //Atribui o comando
                objCmd.CommandText = strSql;
                //Executa a querry
                objCmd.ExecuteNonQuery();


                MessageBox.Show("Dados Cadastrados", "Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Cadastrar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void telaVfinal_Load(object sender, EventArgs e)
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            }
    }
}
