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


    public partial class telaLogin : Form
    {
        
        public telaLogin()
        {
            InitializeComponent();

        }

        private string funcionario = "";
        

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objFunc;

        

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void txtSenha_Layout(object sender, LayoutEventArgs e)
        {
            if (txtSenha == null)
            {
                txtSenha.isPassword = false;
            }
        }

        private void btnVis_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnVis_MouseEnter(object sender, EventArgs e)
        {
            txtSenha.isPassword = false;
        }

        private void btnVis_MouseLeave(object sender, EventArgs e)
        {
            txtSenha.isPassword = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
           // txtLogin.CharacterCasing = CharacterCasing.Lower;
            try
            {
                objCnx = new MySqlConnection(" Persist Security Info=False;" +"server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");
                objCnx.Open();

                string strSql = "select * from tbFuncionario where funNome = '" + txtLogin.Text + "'and funSenha = '" + txtSenha.Text + "'";

                //conexão com o comando
                objCmd.Connection = objCnx;
                //Atribui o comando
                objCmd.CommandText = strSql;
                //Executa a querry
                //objCmd.ExecuteNonQuery();
                objFunc = objCmd.ExecuteReader();

                if (objCnx.State == ConnectionState.Open)
                {
                    objFunc.Read();

                    if (!objFunc.HasRows)
                    {
                        MessageBox.Show("Login ou senha incorretas", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Visible = false;
                        this.Hide();

                        telaLogin ent = new telaLogin();
                        ent.Visible = true;
                    }
                    else
                    {
                        txtL.Text = txtLogin.Text;
                        txtL.Text = txtL.Text.ToLower();
                        Func.Funcionario = txtL.Text;
                        MessageBox.Show("Login e senha corretas", "Bem vindo "+txtL.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        objFunc.Close();
                        objCnx.Close();

                        this.Visible = false;
                        this.Hide();

                        telaSplash sp = new telaSplash();
                        sp.Visible = true;


                        //chamar splahs
                    }
                }
            }

            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro de conexão",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*
            finally
            {
                objFunc.Close();
                objCnx.Close();
            }*/

        }

        private void telaLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
            }
        }

        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
