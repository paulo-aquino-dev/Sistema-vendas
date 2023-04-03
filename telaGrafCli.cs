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
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Russo2
{
    public partial class telaGrafCli : Form
    {
        public telaGrafCli()
        {
            InitializeComponent();
        }

        int v1;
        string sV1;
        int v2;
        string sV2;
        int v3;
        string sV3;
        int v4;
        string sV4;
        int v5;
        string sV5;
        int v6;
        string sV6;
        int v7;
        string sV7;
        int v8;
        string sV8;
        int v9;
        string sV9;
        int v10;
        string sV10;
        int v11;
        string sV11;
        int v12;
        string sV12;
        int mes;

        public string vendedor;

        string vds;

        private MySqlConnection objCnx = new MySqlConnection();
        //usar comandos mysql ocjCmd e usado para utilizar comandos SQL
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataAdapter mAdapter1;
        private MySqlDataAdapter mAdapter2;
        private MySqlDataAdapter mAdapter3;
        private MySqlDataAdapter mAdapter4;
        private MySqlDataAdapter mAdapter5;
        private MySqlDataAdapter mAdapter6;
        private MySqlDataAdapter mAdapter7;
        private MySqlDataAdapter mAdapter8;
        private MySqlDataAdapter mAdapter9;
        private MySqlDataAdapter mAdapter10;
        private MySqlDataAdapter mAdapter11;
        private MySqlDataAdapter mAdapter12;


        private DataSet dat1;
        private DataSet dat2;
        private DataSet dat3;
        private DataSet dat4;
        private DataSet dat5;
        private DataSet dat6;
        private DataSet dat7;
        private DataSet dat8;
        private DataSet dat9;
        private DataSet dat10;
        private DataSet dat11;
        private DataSet dat12;

        DataTable dt = new DataTable();

        ArrayList lista1 = new ArrayList();
        ArrayList lista2 = new ArrayList();
        ArrayList lista3 = new ArrayList();
        ArrayList lista4 = new ArrayList();
        ArrayList lista5 = new ArrayList();
        ArrayList lista6 = new ArrayList();
        ArrayList lista7 = new ArrayList();
        ArrayList lista8 = new ArrayList();
        ArrayList lista9 = new ArrayList();
        ArrayList lista10 = new ArrayList();
        ArrayList lista11 = new ArrayList();
        ArrayList lista12 = new ArrayList();



        private void CreateChart()
        {
            v1 = Convert.ToInt32(sV1);
            v2 = Convert.ToInt32(sV2);
            v3 = Convert.ToInt32(sV3);
            v4 = Convert.ToInt32(sV4);
            v5 = Convert.ToInt32(sV5);
            v6 = Convert.ToInt32(sV6);
            v7 = Convert.ToInt32(sV7);
            v8 = Convert.ToInt32(sV8);
            v9 = Convert.ToInt32(sV9);
            v10 = Convert.ToInt32(sV10);
            v11 = Convert.ToInt32(sV11);
            v12 = Convert.ToInt32(sV12);


            var series = new Series(vds);
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 8;
            series.Points.DataBindXY(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new[] { v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12 });
            chart1.Series.Add(series);

            //var serieV2 = new Series("Vendas2");
            //    serieV2.Points.DataBindXY(new[] { 1, 2,3,4,5,6 }, new[] { 1, 1,2,3,4,5});

            //    serieV2.BorderWidth = 8;
            //    serieV2.ChartType = SeriesChartType.Line;
            //    chart1.Series.Add(serieV2);

        }

        private void telaGrafCli_Load(object sender, EventArgs e)
        {
            

            if (vendedor.Equals("1"))
            {
                vds = "vendedor1";

            }

            else if (vendedor.Equals("2"))
            {
                vds = "vendedor2";

            }

            if (vendedor.Equals("3"))
            {
                vds = "vendedor3";

            }

            if (vendedor.Equals("4"))
            {
                vds = "vendedor4";
            }
            if (vendedor.Equals("5"))
            {
                vds = "Adm";
            }


            try
            {
                dat1 = new DataSet();
                dat2 = new DataSet();
                dat3 = new DataSet();
                dat4 = new DataSet();
                dat5 = new DataSet();
                dat6 = new DataSet();
                dat7 = new DataSet();
                dat8 = new DataSet();
                dat9 = new DataSet();
                dat10 = new DataSet();
                dat11 = new DataSet();
                dat12 = new DataSet();

                objCnx = new MySqlConnection(" Persist Security Info=False;" + "server=192.168.1.201;database=Portal;uid=DBA;pwd=facepr13");

                objCnx.Open();
                if (objCnx.State == ConnectionState.Open)
                {

                    switch (vendedor)
                    {
                        case "1":
                            //MÊS DE JANEIRO-------------------------------------------------------------------------------------------
                            mAdapter1 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas1' and climes = '1';", objCnx);
                            mAdapter1.Fill(dat1, "tbClientes");

                            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
                            {
                                lista1.Add(dtrow1.ItemArray[0]);

                                sV1 = dtrow1.ItemArray[0].ToString();

                                // sV1 = string.Join(" ", lista1.ToArray());

                                if (sV1.Equals(""))
                                {
                                    sV1 = "0";
                                }

                            }
                            //MÊS DE FEVEREIRO-------------------------------------------------------------------------------------------
                            mAdapter2 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas1' and climes = '2';", objCnx);
                            mAdapter2.Fill(dat2, "tbClientes");

                            foreach (DataRow dtrow2 in dat2.Tables[0].Rows)
                            {
                                lista2.Add(dtrow2);

                                sV2 = dtrow2.ItemArray[0].ToString();

                                // sV2 = string.Join(" ", lista2.ToArray());

                                if (sV2.Equals(""))
                                {
                                    sV2 = "0";
                                }
                            }
                            //MÊS DE MARÇO-------------------------------------------------------------------------------------------
                            mAdapter3 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas1' and climes = '3';", objCnx);
                            mAdapter3.Fill(dat3, "tbClientes");

                            foreach (DataRow dtrow3 in dat3.Tables[0].Rows)
                            {
                                lista3.Add(dtrow3.ItemArray[0]);

                                sV3 = dtrow3.ItemArray[0].ToString();

                                // sV3 = string.Join(" ", lista3.ToArray());


                                if (sV3.Equals(""))
                                {
                                    sV3 = "0";
                                }

                            }
                            //MÊS DE ABRIL-------------------------------------------------------------------------------------------
                            mAdapter4 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas1' and climes = '4';", objCnx);
                            mAdapter4.Fill(dat4, "tbClientes");

                            foreach (DataRow dtrow4 in dat4.Tables[0].Rows)
                            {
                                lista4.Add(dtrow4);

                                sV4 = dtrow4.ItemArray[0].ToString();


                                // sV4 = string.Join(" ", lista4.ToArray());

                                if (sV4.Equals(""))
                                {
                                    sV4 = "0";
                                }

                            }
                            //MÊS DE MAIO-------------------------------------------------------------------------------------------
                            mAdapter5 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas1' and climes = '5';", objCnx);
                            mAdapter5.Fill(dat5, "tbClientes");

                            foreach (DataRow dtrow5 in dat5.Tables[0].Rows)
                            {
                                lista5.Add(dtrow5);

                                sV5 = dtrow5.ItemArray[0].ToString();

                                //  sV5 = string.Join(" ", lista5.ToArray());

                                if (sV5.Equals(""))
                                {
                                    sV5 = "0";
                                }

                            }
                            //MÊS DE JUNHO-------------------------------------------------------------------------------------------
                            mAdapter6 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '6';", objCnx);
                            mAdapter6.Fill(dat6, "tbClientes");

                            foreach (DataRow dtrow6 in dat6.Tables[0].Rows)
                            {
                                lista6.Add(dtrow6);

                                sV6 = dtrow6.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV6.Equals(""))
                                {
                                    sV6 = "0";
                                }


                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter7 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '7';", objCnx);
                            mAdapter7.Fill(dat7, "tbClientes");

                            foreach (DataRow dtrow7 in dat7.Tables[0].Rows)
                            {
                                lista7.Add(dtrow7);

                                sV7 = dtrow7.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV7.Equals(""))
                                {
                                    sV7 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter8 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '8';", objCnx);
                            mAdapter8.Fill(dat8, "tbClientes");

                            foreach (DataRow dtrow8 in dat8.Tables[0].Rows)
                            {
                                lista8.Add(dtrow8);

                                sV8 = dtrow8.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV8.Equals(""))
                                {
                                    sV8 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter9 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '9';", objCnx);
                            mAdapter9.Fill(dat9, "tbClientes");

                            foreach (DataRow dtrow9 in dat9.Tables[0].Rows)
                            {
                                lista9.Add(dtrow9);

                                sV9 = dtrow9.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV9.Equals(""))
                                {
                                    sV9 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter10 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '10';", objCnx);
                            mAdapter10.Fill(dat10, "tbClientes");

                            foreach (DataRow dtrow10 in dat10.Tables[0].Rows)
                            {
                                lista10.Add(dtrow10);

                                sV10 = dtrow10.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV10.Equals(""))
                                {
                                    sV10 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter11 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '11';", objCnx);
                            mAdapter11.Fill(dat11, "tbClientes");

                            foreach (DataRow dtrow11 in dat11.Tables[0].Rows)
                            {
                                lista11.Add(dtrow11);

                                sV11 = dtrow11.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV11.Equals(""))
                                {
                                    sV11 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter12 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas1' and promes = '12';", objCnx);
                            mAdapter12.Fill(dat12, "tbClientes");

                            foreach (DataRow dtrow12 in dat12.Tables[0].Rows)
                            {
                                lista12.Add(dtrow12);

                                sV12 = dtrow12.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV12.Equals(""))
                                {
                                    sV12 = "0";
                                }
                            }
                            CreateChart();
                            break;

                        case "2":
                            //MÊS DE JANEIRO-------------------------------------------------------------------------------------------
                            mAdapter1 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '1';", objCnx);
                            mAdapter1.Fill(dat1, "tbClientes");

                            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
                            {
                                lista1.Add(dtrow1.ItemArray[0]);

                                sV1 = dtrow1.ItemArray[0].ToString();

                                // sV1 = string.Join(" ", lista1.ToArray());

                                if (sV1.Equals(""))
                                {
                                    sV1 = "0";
                                }

                            }
                            //MÊS DE FEVEREIRO-------------------------------------------------------------------------------------------
                            mAdapter2 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '2';", objCnx);
                            mAdapter2.Fill(dat2, "tbClientes");

                            foreach (DataRow dtrow2 in dat2.Tables[0].Rows)
                            {
                                lista2.Add(dtrow2);

                                sV2 = dtrow2.ItemArray[0].ToString();

                                // sV2 = string.Join(" ", lista2.ToArray());

                                if (sV2.Equals(""))
                                {
                                    sV2 = "0";
                                }
                            }
                            //MÊS DE MARÇO-------------------------------------------------------------------------------------------
                            mAdapter3 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '3';", objCnx);
                            mAdapter3.Fill(dat3, "tbClientes");

                            foreach (DataRow dtrow3 in dat3.Tables[0].Rows)
                            {
                                lista3.Add(dtrow3.ItemArray[0]);

                                sV3 = dtrow3.ItemArray[0].ToString();

                                // sV3 = string.Join(" ", lista3.ToArray());


                                if (sV3.Equals(""))
                                {
                                    sV3 = "0";
                                }

                            }
                            //MÊS DE ABRIL-------------------------------------------------------------------------------------------
                            mAdapter4 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '4';", objCnx);
                            mAdapter4.Fill(dat4, "tbClientes");

                            foreach (DataRow dtrow4 in dat4.Tables[0].Rows)
                            {
                                lista4.Add(dtrow4);

                                sV4 = dtrow4.ItemArray[0].ToString();


                                // sV4 = string.Join(" ", lista4.ToArray());

                                if (sV4.Equals(""))
                                {
                                    sV4 = "0";
                                }

                            }
                            //MÊS DE MAIO-------------------------------------------------------------------------------------------
                            mAdapter5 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '5';", objCnx);
                            mAdapter5.Fill(dat5, "tbClientes");

                            foreach (DataRow dtrow5 in dat5.Tables[0].Rows)
                            {
                                lista5.Add(dtrow5);

                                sV5 = dtrow5.ItemArray[0].ToString();

                                //  sV5 = string.Join(" ", lista5.ToArray());

                                if (sV5.Equals(""))
                                {
                                    sV5 = "0";
                                }

                            }
                            //MÊS DE JUNHO-------------------------------------------------------------------------------------------
                            mAdapter6 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '6';", objCnx);
                            mAdapter6.Fill(dat6, "tbClientes");

                            foreach (DataRow dtrow6 in dat6.Tables[0].Rows)
                            {
                                lista6.Add(dtrow6);

                                sV6 = dtrow6.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV6.Equals(""))
                                {
                                    sV6 = "0";
                                }


                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter7 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '7';", objCnx);
                            mAdapter7.Fill(dat7, "tbClientes");

                            foreach (DataRow dtrow7 in dat7.Tables[0].Rows)
                            {
                                lista7.Add(dtrow7);

                                sV7 = dtrow7.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV7.Equals(""))
                                {
                                    sV7 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter8 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '8';", objCnx);
                            mAdapter8.Fill(dat8, "tbClientes");

                            foreach (DataRow dtrow8 in dat8.Tables[0].Rows)
                            {
                                lista8.Add(dtrow8);

                                sV8 = dtrow8.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV8.Equals(""))
                                {
                                    sV8 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter9 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '9';", objCnx);
                            mAdapter9.Fill(dat9, "tbClientes");

                            foreach (DataRow dtrow9 in dat9.Tables[0].Rows)
                            {
                                lista9.Add(dtrow9);

                                sV9 = dtrow9.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV9.Equals(""))
                                {
                                    sV9 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter10 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '10';", objCnx);
                            mAdapter10.Fill(dat10, "tbClientes");

                            foreach (DataRow dtrow10 in dat10.Tables[0].Rows)
                            {
                                lista10.Add(dtrow10);

                                sV10 = dtrow10.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV10.Equals(""))
                                {
                                    sV10 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter11 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '11';", objCnx);
                            mAdapter11.Fill(dat11, "tbClientes");

                            foreach (DataRow dtrow11 in dat11.Tables[0].Rows)
                            {
                                lista11.Add(dtrow11);

                                sV11 = dtrow11.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV11.Equals(""))
                                {
                                    sV11 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter12 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas2' and promes = '12';", objCnx);
                            mAdapter12.Fill(dat12, "tbClientes");

                            foreach (DataRow dtrow12 in dat12.Tables[0].Rows)
                            {
                                lista12.Add(dtrow12);

                                sV12 = dtrow12.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV12.Equals(""))
                                {
                                    sV12 = "0";
                                }
                            }
                            CreateChart();
                            break;
                        case "3":
                            //MÊS DE JANEIRO-------------------------------------------------------------------------------------------
                            mAdapter1 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '1';", objCnx);
                            mAdapter1.Fill(dat1, "tbClientes");

                            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
                            {
                                lista1.Add(dtrow1.ItemArray[0]);

                                sV1 = dtrow1.ItemArray[0].ToString();

                                // sV1 = string.Join(" ", lista1.ToArray());

                                if (sV1.Equals(""))
                                {
                                    sV1 = "0";
                                }

                            }
                            //MÊS DE FEVEREIRO-------------------------------------------------------------------------------------------
                            mAdapter2 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '2';", objCnx);
                            mAdapter2.Fill(dat2, "tbClientes");

                            foreach (DataRow dtrow2 in dat2.Tables[0].Rows)
                            {
                                lista2.Add(dtrow2);

                                sV2 = dtrow2.ItemArray[0].ToString();

                                // sV2 = string.Join(" ", lista2.ToArray());

                                if (sV2.Equals(""))
                                {
                                    sV2 = "0";
                                }
                            }
                            //MÊS DE MARÇO-------------------------------------------------------------------------------------------
                            mAdapter3 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '3';", objCnx);
                            mAdapter3.Fill(dat3, "tbClientes");

                            foreach (DataRow dtrow3 in dat3.Tables[0].Rows)
                            {
                                lista3.Add(dtrow3.ItemArray[0]);

                                sV3 = dtrow3.ItemArray[0].ToString();

                                // sV3 = string.Join(" ", lista3.ToArray());


                                if (sV3.Equals(""))
                                {
                                    sV3 = "0";
                                }

                            }
                            //MÊS DE ABRIL-------------------------------------------------------------------------------------------
                            mAdapter4 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '4';", objCnx);
                            mAdapter4.Fill(dat4, "tbClientes");

                            foreach (DataRow dtrow4 in dat4.Tables[0].Rows)
                            {
                                lista4.Add(dtrow4);

                                sV4 = dtrow4.ItemArray[0].ToString();


                                // sV4 = string.Join(" ", lista4.ToArray());

                                if (sV4.Equals(""))
                                {
                                    sV4 = "0";
                                }

                            }
                            //MÊS DE MAIO-------------------------------------------------------------------------------------------
                            mAdapter5 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '5';", objCnx);
                            mAdapter5.Fill(dat5, "tbClientes");

                            foreach (DataRow dtrow5 in dat5.Tables[0].Rows)
                            {
                                lista5.Add(dtrow5);

                                sV5 = dtrow5.ItemArray[0].ToString();

                                //  sV5 = string.Join(" ", lista5.ToArray());

                                if (sV5.Equals(""))
                                {
                                    sV5 = "0";
                                }

                            }
                            //MÊS DE JUNHO-------------------------------------------------------------------------------------------
                            mAdapter6 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '6';", objCnx);
                            mAdapter6.Fill(dat6, "tbClientes");

                            foreach (DataRow dtrow6 in dat6.Tables[0].Rows)
                            {
                                lista6.Add(dtrow6);

                                sV6 = dtrow6.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV6.Equals(""))
                                {
                                    sV6 = "0";
                                }


                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter7 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '7';", objCnx);
                            mAdapter7.Fill(dat7, "tbClientes");

                            foreach (DataRow dtrow7 in dat7.Tables[0].Rows)
                            {
                                lista7.Add(dtrow7);

                                sV7 = dtrow7.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV7.Equals(""))
                                {
                                    sV7 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter8 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '8';", objCnx);
                            mAdapter8.Fill(dat8, "tbClientes");

                            foreach (DataRow dtrow8 in dat8.Tables[0].Rows)
                            {
                                lista8.Add(dtrow8);

                                sV8 = dtrow8.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV8.Equals(""))
                                {
                                    sV8 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter9 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '9';", objCnx);
                            mAdapter9.Fill(dat9, "tbClientes");

                            foreach (DataRow dtrow9 in dat9.Tables[0].Rows)
                            {
                                lista9.Add(dtrow9);

                                sV9 = dtrow9.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV9.Equals(""))
                                {
                                    sV9 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter10 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '10';", objCnx);
                            mAdapter10.Fill(dat10, "tbClientes");

                            foreach (DataRow dtrow10 in dat10.Tables[0].Rows)
                            {
                                lista10.Add(dtrow10);

                                sV10 = dtrow10.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV10.Equals(""))
                                {
                                    sV10 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter11 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '11';", objCnx);
                            mAdapter11.Fill(dat11, "tbClientes");

                            foreach (DataRow dtrow11 in dat11.Tables[0].Rows)
                            {
                                lista11.Add(dtrow11);

                                sV11 = dtrow11.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV11.Equals(""))
                                {
                                    sV11 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter12 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'vendas3' and promes = '12';", objCnx);
                            mAdapter12.Fill(dat12, "tbClientes");

                            foreach (DataRow dtrow12 in dat12.Tables[0].Rows)
                            {
                                lista12.Add(dtrow12);

                                sV12 = dtrow12.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV12.Equals(""))
                                {
                                    sV12 = "0";
                                }
                            }
                            CreateChart();
                            break;
                        case "4":
                            //MÊS DE JANEIRO-------------------------------------------------------------------------------------------
                            mAdapter1 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '1';", objCnx);
                            mAdapter1.Fill(dat1, "tbClientes");

                            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
                            {
                                lista1.Add(dtrow1.ItemArray[0]);

                                sV1 = dtrow1.ItemArray[0].ToString();

                                // sV1 = string.Join(" ", lista1.ToArray());

                                if (sV1.Equals(""))
                                {
                                    sV1 = "0";
                                }

                            }
                            //MÊS DE FEVEREIRO-------------------------------------------------------------------------------------------
                            mAdapter2 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '2';", objCnx);
                            mAdapter2.Fill(dat2, "tbClientes");

                            foreach (DataRow dtrow2 in dat2.Tables[0].Rows)
                            {
                                lista2.Add(dtrow2);

                                sV2 = dtrow2.ItemArray[0].ToString();

                                // sV2 = string.Join(" ", lista2.ToArray());

                                if (sV2.Equals(""))
                                {
                                    sV2 = "0";
                                }
                            }
                            //MÊS DE MARÇO-------------------------------------------------------------------------------------------
                            mAdapter3 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '3';", objCnx);
                            mAdapter3.Fill(dat3, "tbClientes");

                            foreach (DataRow dtrow3 in dat3.Tables[0].Rows)
                            {
                                lista3.Add(dtrow3.ItemArray[0]);

                                sV3 = dtrow3.ItemArray[0].ToString();

                                // sV3 = string.Join(" ", lista3.ToArray());


                                if (sV3.Equals(""))
                                {
                                    sV3 = "0";
                                }

                            }
                            //MÊS DE ABRIL-------------------------------------------------------------------------------------------
                            mAdapter4 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '4';", objCnx);
                            mAdapter4.Fill(dat4, "tbClientes");

                            foreach (DataRow dtrow4 in dat4.Tables[0].Rows)
                            {
                                lista4.Add(dtrow4);

                                sV4 = dtrow4.ItemArray[0].ToString();


                                // sV4 = string.Join(" ", lista4.ToArray());

                                if (sV4.Equals(""))
                                {
                                    sV4 = "0";
                                }

                            }
                            //MÊS DE MAIO-------------------------------------------------------------------------------------------
                            mAdapter5 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '5';", objCnx);
                            mAdapter5.Fill(dat5, "tbClientes");

                            foreach (DataRow dtrow5 in dat5.Tables[0].Rows)
                            {
                                lista5.Add(dtrow5);

                                sV5 = dtrow5.ItemArray[0].ToString();

                                //  sV5 = string.Join(" ", lista5.ToArray());

                                if (sV5.Equals(""))
                                {
                                    sV5 = "0";
                                }

                            }
                            //MÊS DE JUNHO-------------------------------------------------------------------------------------------
                            mAdapter6 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '6';", objCnx);
                            mAdapter6.Fill(dat6, "tbClientes");

                            foreach (DataRow dtrow6 in dat6.Tables[0].Rows)
                            {
                                lista6.Add(dtrow6);

                                sV6 = dtrow6.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV6.Equals(""))
                                {
                                    sV6 = "0";
                                }


                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter7 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '7';", objCnx);
                            mAdapter7.Fill(dat7, "tbClientes");

                            foreach (DataRow dtrow7 in dat7.Tables[0].Rows)
                            {
                                lista7.Add(dtrow7);

                                sV7 = dtrow7.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV7.Equals(""))
                                {
                                    sV7 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter8 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '8';", objCnx);
                            mAdapter8.Fill(dat8, "tbClientes");

                            foreach (DataRow dtrow8 in dat8.Tables[0].Rows)
                            {
                                lista8.Add(dtrow8);

                                sV8 = dtrow8.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV8.Equals(""))
                                {
                                    sV8 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter9 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '9';", objCnx);
                            mAdapter9.Fill(dat9, "tbClientes");

                            foreach (DataRow dtrow9 in dat9.Tables[0].Rows)
                            {
                                lista9.Add(dtrow9);

                                sV9 = dtrow9.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV9.Equals(""))
                                {
                                    sV9 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter10 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '10';", objCnx);
                            mAdapter10.Fill(dat10, "tbClientes");

                            foreach (DataRow dtrow10 in dat10.Tables[0].Rows)
                            {
                                lista10.Add(dtrow10);

                                sV10 = dtrow10.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV10.Equals(""))
                                {
                                    sV10 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter11 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '11';", objCnx);
                            mAdapter11.Fill(dat11, "tbClientes");

                            foreach (DataRow dtrow11 in dat11.Tables[0].Rows)
                            {
                                lista11.Add(dtrow11);

                                sV11 = dtrow11.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV11.Equals(""))
                                {
                                    sV11 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter12 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'vendas4' and climes = '12';", objCnx);
                            mAdapter12.Fill(dat12, "tbClientes");

                            foreach (DataRow dtrow12 in dat12.Tables[0].Rows)
                            {
                                lista12.Add(dtrow12);

                                sV12 = dtrow12.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV12.Equals(""))
                                {
                                    sV12 = "0";
                                }
                            }
                            CreateChart();
                            break;
                        case "5":
                            //MÊS DE JANEIRO-------------------------------------------------------------------------------------------
                            mAdapter1 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'adm' and climes = '1';", objCnx);
                            mAdapter1.Fill(dat1, "tbClientes");

                            foreach (DataRow dtrow1 in dat1.Tables[0].Rows)
                            {
                                lista1.Add(dtrow1.ItemArray[0]);

                                sV1 = dtrow1.ItemArray[0].ToString();

                                // sV1 = string.Join(" ", lista1.ToArray());

                                if (sV1.Equals(""))
                                {
                                    sV1 = "0";
                                }

                            }
                            //MÊS DE FEVEREIRO-------------------------------------------------------------------------------------------
                            mAdapter2 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'adm' and climes = '2';", objCnx);
                            mAdapter2.Fill(dat2, "tbClientes");

                            foreach (DataRow dtrow2 in dat2.Tables[0].Rows)
                            {
                                lista2.Add(dtrow2);

                                sV2 = dtrow2.ItemArray[0].ToString();

                                // sV2 = string.Join(" ", lista2.ToArray());

                                if (sV2.Equals(""))
                                {
                                    sV2 = "0";
                                }
                            }
                            //MÊS DE MARÇO-------------------------------------------------------------------------------------------
                            mAdapter3 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'adm' and climes = '3';", objCnx);
                            mAdapter3.Fill(dat3, "tbClientes");

                            foreach (DataRow dtrow3 in dat3.Tables[0].Rows)
                            {
                                lista3.Add(dtrow3.ItemArray[0]);

                                sV3 = dtrow3.ItemArray[0].ToString();

                                // sV3 = string.Join(" ", lista3.ToArray());


                                if (sV3.Equals(""))
                                {
                                    sV3 = "0";
                                }

                            }
                            //MÊS DE ABRIL-------------------------------------------------------------------------------------------
                            mAdapter4 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'adm' and climes = '4';", objCnx);
                            mAdapter4.Fill(dat4, "tbClientes");

                            foreach (DataRow dtrow4 in dat4.Tables[0].Rows)
                            {
                                lista4.Add(dtrow4);

                                sV4 = dtrow4.ItemArray[0].ToString();


                                // sV4 = string.Join(" ", lista4.ToArray());

                                if (sV4.Equals(""))
                                {
                                    sV4 = "0";
                                }

                            }
                            //MÊS DE MAIO-------------------------------------------------------------------------------------------
                            mAdapter5 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbclientes WHERE cliVendedor = 'adm' and climes = '5';", objCnx);
                            mAdapter5.Fill(dat5, "tbClientes");

                            foreach (DataRow dtrow5 in dat5.Tables[0].Rows)
                            {
                                lista5.Add(dtrow5);

                                sV5 = dtrow5.ItemArray[0].ToString();

                                //  sV5 = string.Join(" ", lista5.ToArray());

                                if (sV5.Equals(""))
                                {
                                    sV5 = "0";
                                }

                            }
                            //MÊS DE JUNHO-------------------------------------------------------------------------------------------
                            mAdapter6 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '6';", objCnx);
                            mAdapter6.Fill(dat6, "tbClientes");

                            foreach (DataRow dtrow6 in dat6.Tables[0].Rows)
                            {
                                lista6.Add(dtrow6);

                                sV6 = dtrow6.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV6.Equals(""))
                                {
                                    sV6 = "0";
                                }


                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter7 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '7';", objCnx);
                            mAdapter7.Fill(dat7, "tbClientes");

                            foreach (DataRow dtrow7 in dat7.Tables[0].Rows)
                            {
                                lista7.Add(dtrow7);

                                sV7 = dtrow7.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV7.Equals(""))
                                {
                                    sV7 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter8 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '8';", objCnx);
                            mAdapter8.Fill(dat8, "tbClientes");

                            foreach (DataRow dtrow8 in dat8.Tables[0].Rows)
                            {
                                lista8.Add(dtrow8);

                                sV8 = dtrow8.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV8.Equals(""))
                                {
                                    sV8 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter9 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '9';", objCnx);
                            mAdapter9.Fill(dat9, "tbClientes");

                            foreach (DataRow dtrow9 in dat9.Tables[0].Rows)
                            {
                                lista9.Add(dtrow9);

                                sV9 = dtrow9.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV9.Equals(""))
                                {
                                    sV9 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter10 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '10';", objCnx);
                            mAdapter10.Fill(dat10, "tbClientes");

                            foreach (DataRow dtrow10 in dat10.Tables[0].Rows)
                            {
                                lista10.Add(dtrow10);

                                sV10 = dtrow10.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV10.Equals(""))
                                {
                                    sV10 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter11 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '11';", objCnx);
                            mAdapter11.Fill(dat11, "tbClientes");

                            foreach (DataRow dtrow11 in dat11.Tables[0].Rows)
                            {
                                lista11.Add(dtrow11);

                                sV11 = dtrow11.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV11.Equals(""))
                                {
                                    sV11 = "0";
                                }
                            }
                            //MÊS DE JULHO------------------------------------------------------------------------------------------
                            mAdapter12 = new MySqlDataAdapter("SELECT COUNT(*) as qtd FROM tbpros WHERE proVendedor = 'adm' and promes = '12';", objCnx);
                            mAdapter12.Fill(dat12, "tbClientes");

                            foreach (DataRow dtrow12 in dat12.Tables[0].Rows)
                            {
                                lista12.Add(dtrow12);

                                sV12 = dtrow12.ItemArray[0].ToString();

                                // sV6 = string.Join(" ", lista6.ToArray());

                                if (sV12.Equals(""))
                                {
                                    sV12 = "0";
                                }
                            }
                            CreateChart();
                            break;

                    }

                }

            }

            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "Erro ao gerar gráfico",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        
    
        }

        private void btnVis_Click(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
