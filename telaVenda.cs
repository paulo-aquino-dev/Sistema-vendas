using MySql.Data.MySqlClient;
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

namespace Russo2
{
    public partial class telaVenda : Form
    {
        public telaVenda()
        {
            InitializeComponent();
        }

        private MySqlConnection objCnx = new MySqlConnection();

        private MySqlCommand objCmd = new MySqlCommand();

        private MySqlDataReader objFunc;

        private MySqlDataAdapter mAdapter;
        private DataSet dat;
        DataTable dt = new DataTable();
        ArrayList lista = new ArrayList();

        public DateTime comeco;

        public string func = "";
        public string categoria;
        public string dataCad;
        public string dia;
        public string dataFinal;
        public string diaRet;
        string clas;


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnS_Click(object sender, EventArgs e)
        {
            categoria = "Vermelha";
            btnS.BackColor = Color.Gray;
            btnAa.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;
            btnCc.BackColor = Color.Transparent;
            btnDd.BackColor = Color.Transparent;

            string caseS = dia;
            switch (caseS)
            {
                case "Segunda-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Terça-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "1";
                    tst.Text = dataFinal;

                    DateTime novaData;
                    TimeSpan diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Terça-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quarta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "1";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quarta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quinta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "1";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Sexta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "1";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sexta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Segunda-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "3";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sabado":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Segunda-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "2";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Domingo":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Segunda-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "3";
                    tst.Text = dataFinal;


                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
         
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            categoria = "Amarelo";
            btnS.BackColor = Color.Transparent;
            btnAa.BackColor = Color.Transparent;
            btnB.BackColor = Color.Gray;
            btnCc.BackColor = Color.Transparent;
            btnDd.BackColor = Color.Transparent;

            string caseB = dia;
            switch (caseB)
            {
                case "Segunda-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Terça-feira da proxima semana!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "8";
                    tst.Text = dataFinal;

                    DateTime novaData;
                    TimeSpan diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Terça-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quarta-feira da proxima semana!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "8";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;

                    break;
                case "Quarta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quinta-feira da proxima semana!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "8";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Sexta-feira da proxima semana!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "8";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sexta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito daqui em 7 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "7";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;

                case "Sabado":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 7 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "9";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Domingo":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 7 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "8";
                    tst.Text = dataFinal;


                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
           
        }

        private void btnD_Click(object sender, EventArgs e)
        {

        
    }

        private void btnRsh_Click(object sender, EventArgs e)
        {
            string mouth = mt.SelectionStart.Month.ToString();


            try
            { 
            string strSql = "INSERT INTO tbPros(proNome , proVendedor , proContato , proDepartamrnto , proTelefone , proEmail , proClass ,proSegmento ,proRamo ,proData ,proCategoria,proDiaretorno,proEstado,proRua,proBairro,proNumero,proCEP,proMes) values(";
                strSql += "'" + txtEmpresa.Text + "',";
                strSql += "'" + Func.Funcionario + "',";
                strSql += "'" + txtResponsavel.Text + "',";
                strSql += "'" + txtDepartamento.Text + "',";
                strSql += "'" + mskTel.Text + "',";
                strSql += "'" + txtEmail.Text + "',";
                strSql += "'" + clas + "',";
                strSql += "'" + cmb1.SelectedItem.ToString() + "',";
                strSql += "'" + txtRamo.Text + "',";
                strSql += "'" + txtDta.Text + "',";
                strSql += "'" + categoria + "',";
                strSql += "'" + diaRet + "',";
                strSql += "'" + cmbEstado.SelectedItem.ToString() + "',";
                strSql += "'" + txtEndereco.Text + "',";
                strSql += "'" + txtBairro.Text+ "',";
                strSql += "'" + txtNum.Text + "',";
                strSql += "'" + mskCEP.Text + "',";
                strSql += "'" + mouth + "')";

                //conexão com o comando
                objCmd.Connection = objCnx;
                //Atribui o comando
                objCmd.CommandText = strSql;
                //Executa a querry
                objCmd.ExecuteNonQuery();


                MessageBox.Show("Aviso", "Dados Cadastrados",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Registro Inserido com Sucesso!!!", "Dados Cadastrados",
                //  MessageBoxButtons.OK, MessageBoxIcon.Information);
                telaResenha tr = new telaResenha();
                this.Visible = false;
                tr.Visible = true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Cadastrar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void telaVenda_Load(object sender, EventArgs e)
        {

            comeco = monthCalendar.SelectionStart;
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



            string mes = DateTime.Now.Month.ToString();

            dia = DateTime.Now.DayOfWeek.ToString();

            string d = DateTime.Now.Day.ToString();

            string dtaa = DateTime.Now.Date.ToShortDateString();

            txtDta.Text = dtaa;

            if (dia.Equals("Monday"))
            {
                dia = "Segunda-feira";
            }

            else if (dia.Equals("Tuesday"))
            {
                dia = "Terça-feira";
            }

            else if (dia.Equals("Wednesday"))
            {
                dia = "Quarta-feira";
            }

            else if (dia.Equals("Thursday"))
            {
                dia = "Quinta-feira";
            }

            else if (dia.Equals("Friday"))
            {
                dia = "Sexta-feira";
            }

            else if (dia.Equals("Saturday"))
            {
                dia = "Sabado";
            }
            else if (dia.Equals("Sunday"))
            {
                dia = "Domingo";
            }

            
            
        }

        private void rdbFabricante_CheckedChanged(object sender, EventArgs e)
        {
            clas = "Fabricante de equipamentos";
        }

        private void rdbManutencao_CheckedChanged(object sender, EventArgs e)
        {
            clas = "Manuntenção";
        }

        private void rdbProducao_CheckedChanged(object sender, EventArgs e)
        {
            clas = "Linha de produção";
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {

        }
            private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            string d = monthCalendar.SelectionEnd.Day.ToString();
            string m = monthCalendar.SelectionEnd.Month.ToString();
            string a = monthCalendar.SelectionEnd.Year.ToString();

            diaRet = d + '/' + m + '/' + a;
        }

        private void btnAa_Click(object sender, EventArgs e)
        {
            categoria = "Laranja";
            btnS.BackColor = Color.Transparent;
            btnAa.BackColor = Color.Gray;
            btnB.BackColor = Color.Transparent;
            btnCc.BackColor = Color.Transparent;
            btnDd.BackColor = Color.Transparent;

            string caseA = dia;
            switch (caseA)
            {
                case "Segunda-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quinta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "3";
                    tst.Text = dataFinal;

                    DateTime novaData;
                    TimeSpan diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;

                case "Terça-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Sexta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "3";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;

                    break;
                case "Quarta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Segunda-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "5";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Terça-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "5";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;


                    break;
                case "Sexta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quarta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "5";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    //
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;

                    break;

                case "Sabado":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quarta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "4";
                    tst.Text = dataFinal;

                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Domingo":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Quarta-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "3";
                    tst.Text = dataFinal;


                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
            }
        }

        private void btnCc_Click(object sender, EventArgs e)
        {
            categoria = "Verde";
            btnS.BackColor = Color.Transparent;
            btnAa.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;
            btnCc.BackColor = Color.Gray;
            btnDd.BackColor = Color.Transparent;

            string caseC = dia;
            switch (caseC)
            {
                case "Segunda-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "21";
                    tst.Text = dataFinal;

                    DateTime  novaData;
                    TimeSpan diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Terça-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "21";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quarta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "21";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "21";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sexta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "21";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sabado":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "24";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Domingo":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 15 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "23";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
            }
        }

        private void btnDd_Click(object sender, EventArgs e)
        {
            categoria = "Azul";
            btnS.BackColor = Color.Transparent;
            btnAa.BackColor = Color.Transparent;
            btnB.BackColor = Color.Transparent;
            btnCc.BackColor = Color.Transparent;
            btnDd.BackColor = Color.Gray;



            string caseD = dia;
            switch (caseD)
            {
                case "Segunda-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito na Terça-feira!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "42";
                    tst.Text = dataFinal;

                    DateTime  novaData;
                    TimeSpan diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Terça-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "42";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quarta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "42";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Quinta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "42";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sexta-feira":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "42";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Sabado":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "44";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
                case "Domingo":
                    MessageBox.Show("Categoria " + categoria + " selecionada, o retorno deve ser feito em 30 dias uteis!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataFinal = "43";
                    tst.Text = dataFinal;
                    diferenca = TimeSpan.Parse(tst.Text);
                    
                    novaData = comeco + diferenca;
                    monthCalendar.SelectionStart = novaData;
                    break;
            }
        }

        private void txtDta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string d = monthCalendar.SelectionEnd.Day.ToString();
            string m = monthCalendar.SelectionEnd.Month.ToString();
            string a = monthCalendar.SelectionEnd.Year.ToString();

            diaRet = a + '/' + m + '/' + d;

            MessageBox.Show(diaRet, "Dados Cadastrados",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCEP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVeri_Click(object sender, EventArgs e)
        {
            try
            {

                dat = new DataSet();
                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");
                objCnx.Open();

                string strSql = "select * from tbPros where proNome = '" + txtEmpresa.Text + "'";

                mAdapter = new MySqlDataAdapter("select * from tbPros where proNome = '"+txtEmpresa.Text+"';", objCnx);
                mAdapter.Fill(dat, "tbProspec");


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
                    string ven = "";

                    if (!objFunc.HasRows)
                    {
                        MessageBox.Show("Está empresa ainda não foi cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        foreach (DataRow dtrow in dat.Tables[0].Rows)
                        {
                            lista.Add(dtrow);
                            ven = dtrow.ItemArray[2].ToString();
                            MessageBox.Show("Está empresa já foi cadastrada pelo vendedor: " + ven, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            finally
            {
                objFunc.Close();
            }
        }

        private void btnBusca_Click(object sender, EventArgs e)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
