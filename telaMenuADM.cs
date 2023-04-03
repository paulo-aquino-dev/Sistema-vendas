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
using System.Net;
using System.Net.Mail;

namespace Russo2
{
    public partial class telaMenuADM : Form
    {
        public telaMenuADM()
        {
            InitializeComponent();
        }

        public int vend;
        public bool seg;


        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataAdapter mAdapter;
        private DataSet dat;
        string result;
        private DataSet dCount;
        DataTable dt = new DataTable();

        ArrayList lista = new ArrayList();
        ArrayList teste = new ArrayList();

        private void vendas1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 1;
            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 1;

            tlc.Visible = true;
        }

        private void vendas2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 2;
            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 1;

            tlc.Visible = true;
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 1;

            tlc.Visible = true;
        }

        private void vendas1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 1;
            tlv.tru = 1;

            tlv.Visible = true;
        }

        private void vendas2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
 
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 2;
            tlv.tru = 1;

            tlv.Visible = true;
        }

        private void todosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = vend;

            tlv.Visible = true;
        }

        private void vendas1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 1;
            telaPesCliente tpc = new telaPesCliente();
            tpc.MdiParent = this;
            tpc.vds = vend;

            tpc.Visible = true;
        }

        private void vendas2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 2;
            telaPesCliente tpc = new telaPesCliente();
            tpc.MdiParent = this;
            tpc.vds = vend;

            tpc.Visible = true;
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaPesCliente tpc = new telaPesCliente();
            tpc.MdiParent = this;
            tpc.vds = vend;

            tpc.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prospecçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendas1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // TELA DE´PESQUISA DE PROSPCÇÃO

            vend = 1;
            telaPesVenda tpv = new telaPesVenda();
            tpv.MdiParent = this;
            tpv.vds = vend;

            tpv.Visible = true;
        }

        private void vendas2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vend = 2;
            telaPesVenda tpv = new telaPesVenda();
            tpv.MdiParent = this;
            tpv.vds = vend;

            tpv.Visible = true;
        }

        private void todosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaPesVenda tpv = new telaPesVenda();
            tpv.MdiParent = this;
            tpv.vds = vend;

            tpv.Visible = true;
        }

        private void prospectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVenda tv = new telaVenda();
            tv.MdiParent = this;


            tv.Visible = true;
        }

        private void segmentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 3;
            seg = true;
            telaPesVenda tpv = new telaPesVenda();
            tpv.MdiParent = this;
            tpv.vds = vend;
            tpv.sgmt = seg;
            tpv.Visible = true;
        }

        private void segmentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaPesCliente tpc = new telaPesCliente();
            tpc.MdiParent = this;
            tpc.vds = vend;
            tpc.sgmt = true;
            tpc.Visible = true;
        }

        private void vendas1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            telaAgenda tag = new telaAgenda();
            tag.MdiParent = this;
            tag.agd = 1;
            tag.Visible = true;
        }

        private void vendas2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            telaAgenda tag = new telaAgenda();
            tag.MdiParent = this;
            tag.agd = 2;
            tag.Visible = true;
        }

        private void vendas3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAgenda tag = new telaAgenda();
            tag.MdiParent = this;
            tag.agd = 3;
            tag.Visible = true;
        }

        private void vendas4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaAgenda tag = new telaAgenda();
            tag.MdiParent = this;
            tag.agd = 4;
            tag.Visible = true;
        }

        private void vendas4ToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void telaMenuADM_Load(object sender, EventArgs e)
        {
            try
            {
                dat = new DataSet();
                dCount = new DataSet();
                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

                objCnx.Open();

                string vendedor = Func.Funcionario;

                switch (vendedor)
                {

                    case "vendas1":
                        {

                            string dia = dateTimePicker1.Value.Date.ToShortDateString();

                            mAdapter = new MySqlDataAdapter("select pronome,prodiaretorno from tbpros WHERE prodiaRetorno <'" + dia + "' and proVendedor = 'vendas1';", objCnx);
                            mAdapter.Fill(dat, "tbProspec");
                            MySqlDataAdapter mCount;
                            mCount = new MySqlDataAdapter("Select count(*) from tbpros where prodiaretorno <'" + dia + "';", objCnx);
                            mCount.Fill(dCount, "tbP");

                            foreach (DataRow dtrow in dat.Tables[0].Rows)
                            {
                                lista.Add("Empresa: " + dtrow.ItemArray[0] + ", o retorno deveria ter sido efetuado em: " + dtrow.ItemArray[1]);

                                result = string.Join(" ", lista.ToArray());
                                Console.WriteLine(result);

                            }


                            foreach (DataRow count in dCount.Tables[0].Rows)
                            {
                                teste.Add(count.ItemArray[0]);
                                string Confere = count.ItemArray[0].ToString();

                                if (Confere != "0")
                                {
                                    var msg = new MailMessage("alertadeatraso@gmail.com", "adm@portaldocromo.com.br");
                                    msg.Subject = "Atraso do " + Func.Funcionario;
                                    msg.Body = "O vendedor1 está atrasado para dar continuidade a(s) seguinte(s) prospecções: " + result;


                                    // sc.UseDefaultCredentials = false;

                                    using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                                    {
                                        sc.UseDefaultCredentials = true;

                                        sc.EnableSsl = true;
                                        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                                        sc.Credentials = new NetworkCredential("alertadeatraso@gmail.com", "guanabug123");//your mail password

                                        sc.Send(msg);
                                    }



                                }
                            }

                            foreach (DataRow count in dCount.Tables[0].Rows)
                            {
                                teste.Add(count.ItemArray[0]);
                                string Confere = count.ItemArray[0].ToString();

                                if (Confere != "0")
                                {
                                    var msg = new MailMessage("alertadeatraso@gmail.com", "gestao.comercial@portaldocromo.com.br");
                                    msg.Subject = "Atraso do " + Func.Funcionario;
                                    msg.Body = "O vendedor1 está atrasado para dar continuidade a(s) seguinte(s) prospecções: " + result;


                                    // sc.UseDefaultCredentials = false;

                                    using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                                    {
                                        sc.UseDefaultCredentials = true;

                                        sc.EnableSsl = true;
                                        sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                                        sc.Credentials = new NetworkCredential("alertadeatraso@gmail.com", "guanabug123");//your mail password

                                        sc.Send(msg);
                                    }
                                }
                            }
                        }
                        break;
                    case "vendas2":
                        {
                            if (objCnx.State == ConnectionState.Open)
                            {

                                string dia = dateTimePicker1.Value.Date.ToShortDateString();

                                mAdapter = new MySqlDataAdapter("select pronome,prodiaretorno from tbpros WHERE prodiaRetorno <'" + dia + "' and proVendedor = 'vendas2';", objCnx);
                                mAdapter.Fill(dat, "tbProspec");
                                MySqlDataAdapter mCount;
                                mCount = new MySqlDataAdapter("Select count(*) from tbpros where prodiaretorno <'" + dia + "';", objCnx);
                                mCount.Fill(dCount, "tbP");

                                foreach (DataRow dtrow in dat.Tables[0].Rows)
                                {
                                    lista.Add("Empresa: " + dtrow.ItemArray[0] + ", o retorno deveria ter sido efetuado em: " + dtrow.ItemArray[1]);

                                    result = string.Join(" ", lista.ToArray());
                                    Console.WriteLine(result);

                                }


                                foreach (DataRow count in dCount.Tables[0].Rows)
                                {
                                    teste.Add(count.ItemArray[0]);
                                    string Confere = count.ItemArray[0].ToString();

                                    if (Confere != "0")
                                    {
                                        var msg = new MailMessage("alertadeatraso@gmail.com", "adm@portaldocromo.com.br");
                                        msg.Subject = "Atraso do " + Func.Funcionario;
                                        msg.Body = "O vendedor2 está atrasado para dar continuidade a(s) seguinte(s) prospecções: " + result;


                                        // sc.UseDefaultCredentials = false;

                                        using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                                        {
                                            sc.UseDefaultCredentials = true;

                                            sc.EnableSsl = true;
                                            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                                            sc.Credentials = new NetworkCredential("alertadeatraso@gmail.com", "guanabug123");//your mail password

                                            sc.Send(msg);
                                        }

                                    }


                                }

                                foreach (DataRow count in dCount.Tables[0].Rows)
                                {
                                    teste.Add(count.ItemArray[0]);
                                    string Confere = count.ItemArray[0].ToString();

                                    if (Confere != "0")
                                    {
                                        var msg = new MailMessage("alertadeatraso@gmail.com", "gestao.comercial@portaldocromo.com.br");
                                        msg.Subject = "Atraso do " + Func.Funcionario;
                                        msg.Body = "O vendedor2 está atrasado para dar continuidade a(s) seguinte(s) prospecções: " + result;


                                        // sc.UseDefaultCredentials = false;

                                        using (SmtpClient sc = new SmtpClient("smtp.gmail.com", 587))
                                        {
                                            sc.UseDefaultCredentials = true;

                                            sc.EnableSsl = true;
                                            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                                            sc.Credentials = new NetworkCredential("alertadeatraso@gmail.com", "guanabug123");//your mail password

                                            sc.Send(msg);
                                        }

                                    }
                                }
                            }

                        }
                        break;
                }
            } 
            catch (Exception Erro)
            {
                MessageBox.Show("ERRO ==> " + Erro.Message, "Erro ao Listar Dados!!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            if (Func.Funcionario.Equals("vendas1"))
            {
                cadastrarCli.Visible = false;
                 
                agendaV2.Visible = false;
                agendaV3.Visible = false;
                agendaV4.Visible = false;

                pesProsSegmento.Visible = false;
                pesProsV2.Visible = false;
                pesProsV3.Visible = false;
                pesProsV4.Visible = false;
                pesProsAll.Visible = false;
                
                lisProsV2.Visible = false;
                lisProsV3.Visible = false;
                lisProsV4.Visible = false;
                lisProsAll.Visible = false;


                lisCliV2.Visible = false;
                lisCliV3.Visible = false;
                lisCliV4.Visible = false;
                lisCliAll.Visible = false;

                pesCliSegmento.Visible = false;
                pesCliV2.Visible = false;
                pesCliV3.Visible = false;
                pesCliV4.Visible = false;
                pesCliAll.Visible = false;

                vendedor2ToolStripMenuItem.Visible = false;
                vendedor3ToolStripMenuItem.Visible = false;
                vendedor4ToolStripMenuItem.Visible = false;

                
                c2.Visible = false;
                c3.Visible = false;
                c4.Visible = false;

                clientesToolStripMenuItem.Visible = false;

            }
            else if (Func.Funcionario.Equals("vendas2"))
            {
                cadastrarCli.Visible = false;
                
                agendaV1.Visible = false;
                agendaV3.Visible = false;
                agendaV4.Visible = false;

                pesProsSegmento.Visible = false;
                pesProsV1.Visible = false;
                pesProsV3.Visible = false;
                pesProsV4.Visible = false;
                pesProsAll.Visible = false;

                lisProsV1.Visible = false;
                lisProsV3.Visible = false;
                lisProsV4.Visible = false;
                lisProsAll.Visible = false;


                lisCliV1.Visible = false;
                lisCliV3.Visible = false;
                lisCliV4.Visible = false;
                lisCliAll.Visible = false;

                pesCliSegmento.Visible = false;
                pesCliV1.Visible = false;
                pesCliV3.Visible = false;
                pesCliV4.Visible = false;
                pesCliAll.Visible = false;

                vendedor1ToolStripMenuItem.Visible = false;
                vendedor3ToolStripMenuItem.Visible = false;
                vendedor4ToolStripMenuItem.Visible = false;

                c1.Visible = false;
                c3.Visible = false;
                c4.Visible = false;

                clientesToolStripMenuItem.Visible = false;
            }
            else if (Func.Funcionario.Equals("vendas3"))
            {
                cadastrarCli.Visible = false;
                
                agendaV2.Visible = false;
                agendaV1.Visible = false;
                agendaV4.Visible = false;

                pesProsSegmento.Visible = false;
                pesProsV2.Visible = false;
                pesProsV1.Visible = false;
                pesProsV4.Visible = false;
                pesProsAll.Visible = false;

                lisProsV2.Visible = false;
                lisProsV1.Visible = false;
                lisProsV4.Visible = false;
                lisProsAll.Visible = false;


                lisCliV2.Visible = false;
                lisCliV1.Visible = false;
                lisCliV4.Visible = false;
                lisCliAll.Visible = false;

                pesCliSegmento.Visible = false;
                pesCliV2.Visible = false;
                pesCliV1.Visible = false;
                pesCliV4.Visible = false;
                pesCliAll.Visible = false;

                vendedor2ToolStripMenuItem.Visible = false;
                vendedor1ToolStripMenuItem.Visible = false;
                vendedor4ToolStripMenuItem.Visible = false;

                c2.Visible = false;
                c1.Visible = false;
                c4.Visible = false;

                
            }
            else if (Func.Funcionario.Equals("vendas4"))
            {
                cadastrarCli.Visible = false;
                 
                agendaV2.Visible = false;
                agendaV3.Visible = false;
                agendaV1.Visible = false;

                pesProsSegmento.Visible = false;
                pesProsV2.Visible = false;
                pesProsV3.Visible = false;
                pesProsV1.Visible = false;
                pesProsAll.Visible = false;

                lisProsV2.Visible = false;
                lisProsV3.Visible = false;
                lisProsV1.Visible = false;
                lisProsAll.Visible = false;


                lisCliV2.Visible = false;
                lisCliV3.Visible = false;
                lisCliV1.Visible = false;
                lisCliAll.Visible = false;

                pesCliSegmento.Visible = false;
                pesCliV2.Visible = false;
                pesCliV3.Visible = false;
                pesCliV1.Visible = false;
                pesCliAll.Visible = false;

                vendedor2ToolStripMenuItem.Visible = false;
                vendedor3ToolStripMenuItem.Visible = false;
                vendedor1ToolStripMenuItem.Visible = false;

                c2.Visible = false;
                c3.Visible = false;
                c1.Visible = false;

                clientesToolStripMenuItem.Visible = false;
            }
            else if (Func.Funcionario.Equals("cadastro"))
            {
                gráficosToolStripMenuItem.Visible = false;

                menuAgenda.Visible = false;
                agendaV1.Visible = false;
                agendaV2.Visible = false;
                agendaV3.Visible = false;
                agendaV4.Visible = false;

                menuProspeccao.Visible = false;
                pesProsSegmento.Visible = false;
                pesProsV1.Visible = false;
                pesProsV2.Visible = false;
                pesProsV3.Visible = false;
                pesProsV4.Visible = false;
                pesProsAll.Visible = false;

                menuLisCli.Visible = false;
                lisProsV1.Visible = false;
                lisProsV2.Visible = false;
                lisProsV3.Visible = false;
                lisProsV4.Visible = false;
                lisProsAll.Visible = false;


                menuPesCli.Visible = false;
                lisCliV1.Visible = false;
                lisCliV2.Visible = false;
                lisCliV3.Visible = false;
                lisCliV4.Visible = false;
                lisCliAll.Visible = false;

                pesCliSegmento.Visible = false;
                pesCliV1.Visible = false;
                pesCliV2.Visible = false;
                pesCliV3.Visible = false;
                pesCliV4.Visible = false;
                pesCliAll.Visible = false;

                
            }
            else if (Func.Funcionario.Equals("gestor"))
            {

                cadastrarCli.Visible = false;
                menuAgenda.Visible = false;
                agendaV1.Visible = false;
                agendaV2.Visible = false;
                agendaV3.Visible = false;
                agendaV4.Visible = false;
            }
            else if (Func.Funcionario.Equals("adm"))
            {
                pvv.Visible = true;
                cvv.Visible = true;
                LisClisAdm.Visible = true;
                PesCliAdm.Visible = true;
                LisClisAdm.Visible = true;
                PesCliAdm.Visible = true;
                GraCliAdm.Visible = true;
                GrafProsAdm.Visible = true;
                GraVenAdm.Visible = true;
                AgeAdm.Visible = true;

            }
        }

        private void prospectar(object sender, EventArgs e)
        {
            telaVenda tv = new telaVenda();
            tv.MdiParent = this;
            tv.Visible = true;
        }

        private void cadastrarCli_Click(object sender, EventArgs e)
        {
            telaCliente tc = new telaCliente();
            tc.MdiParent = this;
            tc.Visible = true;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void prospecçõesDeletadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 1;
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = vend;
            tlv.tru = 0;

            tlv.Visible = true;
        }

        private void vendedor1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaGrafP tgp = new telaGrafP();
            tgp.MdiParent = this;
            tgp.vendedor = "1";

            tgp.Visible = true;
        }

        private void vendedor2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaGrafP tgp = new telaGrafP();
            tgp.MdiParent = this;
            tgp.vendedor = "2";

            tgp.Visible = true;
        }

        private void vendedor3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaGrafP tgp = new telaGrafP();
            tgp.MdiParent = this;
            tgp.vendedor = "3";

            tgp.Visible = true;
        }

        private void vendedor4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaGrafP tgp = new telaGrafP();
            tgp.MdiParent = this;
            tgp.vendedor = "4";

            tgp.Visible = true;
        }

        private void prospcçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gráficosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lisCliV3_Click(object sender, EventArgs e)
        {

        }

        private void c1_Click(object sender, EventArgs e)
        {
            telaGrafCli tgc = new telaGrafCli();
            tgc.MdiParent = this;
            tgc.vendedor = "1";
            tgc.Visible = true;

        }

        private void c2_Click(object sender, EventArgs e)
        {
            telaGrafCli tgc = new telaGrafCli();
            tgc.MdiParent = this;
            tgc.vendedor = "2";
            tgc.Visible = true;
        }

        private void c3_Click(object sender, EventArgs e)
        {
            telaGrafCli tgc = new telaGrafCli();
            tgc.MdiParent = this;
            tgc.vendedor = "3";
            tgc.Visible = true;
        }

        private void c4_Click(object sender, EventArgs e)
        {
            telaGrafCli tgc = new telaGrafCli();
            tgc.MdiParent = this;
            tgc.vendedor = "4";
            tgc.Visible = true;
        }

        private void cadastrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaVfinal tvf = new telaVfinal();
            tvf.MdiParent = this;
            tvf.Visible = true;
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendas1ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaGrafVenda tgv = new telaGrafVenda();
            tgv.MdiParent = this;
            tgv.vendedor = "1";
            tgv.Visible = true;
        }

        private void vendas2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaGrafVenda tgv = new telaGrafVenda();
            tgv.MdiParent = this;
            tgv.vendedor = "2";
            tgv.Visible = true;
        }

        private void vendas3ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaGrafVenda tgv = new telaGrafVenda();
            tgv.MdiParent = this;
            tgv.vendedor = "3";
            tgv.Visible = true;
        }

        private void vendas4ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaGrafVenda tgv = new telaGrafVenda();
            tgv.MdiParent = this;
            tgv.vendedor = "4";
            tgv.Visible = true;
        }

        private void lisProsV3_Click(object sender, EventArgs e)
        {
            
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 3;
            tlv.tru = 1;

            tlv.Visible = true;
        }

        private void lisProsV4_Click(object sender, EventArgs e)
        {
            
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 4;
            tlv.tru = 1;

            tlv.Visible = true;
        }

        private void prospecçõesDeletadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 2;
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = vend;
            tlv.tru = 0;

            tlv.Visible = true;
        }

        private void prospecçõesDeletadasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            vend = 3;
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = vend;
            tlv.tru = 0;

            tlv.Visible = true;
        }

        private void prospecçõesDeletadasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vend = 4;
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = vend;
            tlv.tru = 0;

            tlv.Visible = true;
        }

        private void pesProsV3_Click(object sender, EventArgs e)
        {

        }

        private void pesProsV4_Click(object sender, EventArgs e)
        {

        }

        private void pesquisarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLisOrc tlo = new telaLisOrc();
            tlo.MdiParent = this;
            tlo.Visible = true;
        }

        private void admToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            vend = 5;
            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 1;

            tlc.Visible = true;
        }

        private void admToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 5;
            telaPesCliente tpc = new telaPesCliente();
            tpc.MdiParent = this;
            tpc.vds = vend;

            tpc.Visible = true;
        }

        private void admToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 5;
            tlv.tru = 1;

            tlv.Visible = true;
        }

        private void prospecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaLisVenda tlv = new telaLisVenda();
            tlv.MdiParent = this;
            tlv.vds = 5;
            tlv.tru = 0;

            tlv.Visible = true;
        }

        private void admToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vend = 5;
            telaPesVenda tpv = new telaPesVenda();
            tpv.MdiParent = this;
            tpv.vds = vend;

            tpv.Visible = true;
        }

        private void admToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            telaGrafP tgp = new telaGrafP();
            tgp.MdiParent = this;
            tgp.vendedor = "5";

            tgp.Visible = true;
        }

        private void admToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            telaGrafCli tgc = new telaGrafCli();
            tgc.MdiParent = this;
            tgc.vendedor = "5";
            tgc.Visible = true;
        }

        private void admToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            telaGrafVenda tgv = new telaGrafVenda();
            tgv.MdiParent = this;
            tgv.vendedor = "5";
            tgv.Visible = true;
        }

        private void admToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            telaAgenda tag = new telaAgenda();
            tag.MdiParent = this;
            tag.agd = 5;
            tag.Visible = true;
        }

        private void clientesDeletadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vend = 5;
            
            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 0;

            tlc.Visible = true;
        }

        private void clientesDeletadosToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            vend = 2;

            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 0;

            tlc.Visible = true;
        }

        private void clientesDeletadosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            vend = 1;

            telaLisCliente tlc = new telaLisCliente();
            tlc.MdiParent = this;
            tlc.vds = vend;
            tlc.tru = 0;

            tlc.Visible = true;
        }

        private void menuLisCli_Click(object sender, EventArgs e)
        {

        }
    }
}
