namespace Russo2
{
    partial class telaCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCliente));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnCEP = new System.Windows.Forms.Button();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNfantasia = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtRamoA = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.rdbRet = new System.Windows.Forms.RadioButton();
            this.rdbRetFora = new System.Windows.Forms.RadioButton();
            this.lblRet = new System.Windows.Forms.Label();
            this.lblRetFora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.rdbInd2 = new System.Windows.Forms.RadioButton();
            this.rdbInd1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.mskInsc = new System.Windows.Forms.MaskedTextBox();
            this.cmbVend = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmbSegmento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // mskCEP
            // 
            this.mskCEP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCEP.Location = new System.Drawing.Point(76, 653);
            this.mskCEP.Mask = "#####-###";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(311, 32);
            this.mskCEP.TabIndex = 11;
            // 
            // btnCEP
            // 
            this.btnCEP.Location = new System.Drawing.Point(568, 653);
            this.btnCEP.Name = "btnCEP";
            this.btnCEP.Size = new System.Drawing.Size(163, 31);
            this.btnCEP.TabIndex = 102;
            this.btnCEP.Text = "Buscar";
            this.btnCEP.UseVisualStyleBackColor = true;
            this.btnCEP.Click += new System.EventHandler(this.btnCEP_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(420, 713);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(311, 32);
            this.txtBairro.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(76, 716);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(311, 32);
            this.txtCidade.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(76, 776);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(311, 32);
            this.txtEndereco.TabIndex = 15;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(420, 776);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(311, 32);
            this.txtNum.TabIndex = 17;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(282, 824);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(254, 32);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(39, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Código";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(35, 115);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(311, 32);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // txtNfantasia
            // 
            this.txtNfantasia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNfantasia.Location = new System.Drawing.Point(368, 115);
            this.txtNfantasia.Name = "txtNfantasia";
            this.txtNfantasia.Size = new System.Drawing.Size(311, 32);
            this.txtNfantasia.TabIndex = 4;
            this.txtNfantasia.TextChanged += new System.EventHandler(this.txtNfantasia_TextChanged);
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(35, 246);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(311, 32);
            this.txtContato.TabIndex = 7;
            // 
            // txtRamoA
            // 
            this.txtRamoA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRamoA.Location = new System.Drawing.Point(368, 180);
            this.txtRamoA.Name = "txtRamoA";
            this.txtRamoA.Size = new System.Drawing.Size(311, 32);
            this.txtRamoA.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(35, 52);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(167, 32);
            this.txtCod.TabIndex = 1;
            // 
            // rdbRet
            // 
            this.rdbRet.AutoSize = true;
            this.rdbRet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRet.Location = new System.Drawing.Point(368, 504);
            this.rdbRet.Name = "rdbRet";
            this.rdbRet.Size = new System.Drawing.Size(74, 28);
            this.rdbRet.TabIndex = 9;
            this.rdbRet.TabStop = true;
            this.rdbRet.Text = "CFOP";
            this.rdbRet.UseVisualStyleBackColor = true;
            this.rdbRet.CheckedChanged += new System.EventHandler(this.rdbRet_CheckedChanged);
            // 
            // rdbRetFora
            // 
            this.rdbRetFora.AutoSize = true;
            this.rdbRetFora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRetFora.Location = new System.Drawing.Point(368, 531);
            this.rdbRetFora.Name = "rdbRetFora";
            this.rdbRetFora.Size = new System.Drawing.Size(74, 28);
            this.rdbRetFora.TabIndex = 10;
            this.rdbRetFora.TabStop = true;
            this.rdbRetFora.Text = "CFOP";
            this.rdbRetFora.UseVisualStyleBackColor = true;
            this.rdbRetFora.CheckedChanged += new System.EventHandler(this.rdbRetFora_CheckedChanged);
            // 
            // lblRet
            // 
            this.lblRet.AutoSize = true;
            this.lblRet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRet.Location = new System.Drawing.Point(448, 506);
            this.lblRet.Name = "lblRet";
            this.lblRet.Size = new System.Drawing.Size(61, 24);
            this.lblRet.TabIndex = 7;
            this.lblRet.Text = "- 5915";
            // 
            // lblRetFora
            // 
            this.lblRetFora.AutoSize = true;
            this.lblRetFora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetFora.Location = new System.Drawing.Point(448, 533);
            this.lblRetFora.Name = "lblRetFora";
            this.lblRetFora.Size = new System.Drawing.Size(61, 24);
            this.lblRetFora.TabIndex = 8;
            this.lblRetFora.Text = "- 6915";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Razão social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nome fantasia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(372, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "CNPJ";
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(368, 246);
            this.mskCPF.Mask = "###.###.###-##";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(311, 32);
            this.mskCPF.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Ramo de atividade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Contato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "CPF";
            // 
            // mskCNPJ
            // 
            this.mskCNPJ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCNPJ.Location = new System.Drawing.Point(368, 52);
            this.mskCNPJ.Mask = "##.###.###/####-##";
            this.mskCNPJ.Name = "mskCNPJ";
            this.mskCNPJ.Size = new System.Drawing.Size(311, 32);
            this.mskCNPJ.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Vendedor";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(372, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Inscrição estadual";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.rdbInd2);
            this.panel1.Controls.Add(this.rdbInd1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.mskInsc);
            this.panel1.Controls.Add(this.cmbVend);
            this.panel1.Controls.Add(this.bunifuCustomLabel10);
            this.panel1.Controls.Add(this.cmbSegmento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.mskCNPJ);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mskCPF);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblRetFora);
            this.panel1.Controls.Add(this.lblRet);
            this.panel1.Controls.Add(this.rdbRetFora);
            this.panel1.Controls.Add(this.rdbRet);
            this.panel1.Controls.Add(this.txtCod);
            this.panel1.Controls.Add(this.txtRamoA);
            this.panel1.Controls.Add(this.txtContato);
            this.panel1.Controls.Add(this.txtNfantasia);
            this.panel1.Controls.Add(this.txtRazaoSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(65, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 565);
            this.panel1.TabIndex = 99;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(39, 361);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 24);
            this.label20.TabIndex = 127;
            this.label20.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 388);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(644, 81);
            this.txtEmail.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(111, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 125;
            this.label1.Text = "- 6901";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 12F);
            this.label19.Location = new System.Drawing.Point(111, 503);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 24);
            this.label19.TabIndex = 124;
            this.label19.Text = "- 5901";
            // 
            // rdbInd2
            // 
            this.rdbInd2.AutoSize = true;
            this.rdbInd2.Font = new System.Drawing.Font("Calibri", 12F);
            this.rdbInd2.Location = new System.Drawing.Point(36, 531);
            this.rdbInd2.Name = "rdbInd2";
            this.rdbInd2.Size = new System.Drawing.Size(74, 28);
            this.rdbInd2.TabIndex = 122;
            this.rdbInd2.TabStop = true;
            this.rdbInd2.Text = "CFOP";
            this.rdbInd2.UseVisualStyleBackColor = true;
            this.rdbInd2.CheckedChanged += new System.EventHandler(this.rdbInd2_CheckedChanged);
            // 
            // rdbInd1
            // 
            this.rdbInd1.AutoSize = true;
            this.rdbInd1.Font = new System.Drawing.Font("Calibri", 12F);
            this.rdbInd1.Location = new System.Drawing.Point(37, 503);
            this.rdbInd1.Name = "rdbInd1";
            this.rdbInd1.Size = new System.Drawing.Size(74, 28);
            this.rdbInd1.TabIndex = 123;
            this.rdbInd1.TabStop = true;
            this.rdbInd1.Text = "CFOP";
            this.rdbInd1.UseVisualStyleBackColor = true;
            this.rdbInd1.CheckedChanged += new System.EventHandler(this.rdbInd1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 472);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 29);
            this.label9.TabIndex = 119;
            this.label9.Text = "Industrialização";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(361, 472);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(219, 29);
            this.label18.TabIndex = 118;
            this.label18.Text = "Prestação de Serviço";
            // 
            // mskInsc
            // 
            this.mskInsc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskInsc.Location = new System.Drawing.Point(368, 313);
            this.mskInsc.Name = "mskInsc";
            this.mskInsc.Size = new System.Drawing.Size(311, 32);
            this.mskInsc.TabIndex = 10;
            // 
            // cmbVend
            // 
            this.cmbVend.FormattingEnabled = true;
            this.cmbVend.ItemHeight = 24;
            this.cmbVend.Items.AddRange(new object[] {
            "Vendas1",
            "Vendas2",
            "Vendas3",
            "Vendas4",
            "Adm"});
            this.cmbVend.Location = new System.Drawing.Point(35, 313);
            this.cmbVend.Name = "cmbVend";
            this.cmbVend.Size = new System.Drawing.Size(311, 32);
            this.cmbVend.TabIndex = 9;
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(39, 155);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(87, 23);
            this.bunifuCustomLabel10.TabIndex = 117;
            this.bunifuCustomLabel10.Text = "Segmento";
            // 
            // cmbSegmento
            // 
            this.cmbSegmento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSegmento.Items.AddRange(new object[] {
            "Aeroespacial",
            "Agrícola",
            "Alimentício",
            "Automobilística",
            "Aviação",
            "Borracha",
            "Calçadista",
            "Cerâmica",
            "Farmacêutica",
            "Gráfico",
            "Higiene",
            "Hospitalar",
            "Mecânica\t",
            "Mineração",
            "Naval",
            "Ótica",
            "Papel",
            "Papelão",
            "Petróleo e gás",
            "Petroquímica",
            "Plástico",
            "Química",
            "Siderúrgica",
            "Têxtil",
            "Trefilacão",
            "Vidro"});
            this.cmbSegmento.Location = new System.Drawing.Point(36, 180);
            this.cmbSegmento.Name = "cmbSegmento";
            this.cmbSegmento.Size = new System.Drawing.Size(310, 32);
            this.cmbSegmento.TabIndex = 5;
            this.cmbSegmento.Text = "Segmento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(423, 750);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 23);
            this.label12.TabIndex = 130;
            this.label12.Text = "Número";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(78, 750);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 23);
            this.label13.TabIndex = 129;
            this.label13.Text = "Endereço";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(423, 689);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 128;
            this.label14.Text = "Bairro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 689);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 23);
            this.label15.TabIndex = 127;
            this.label15.Text = "Cidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(423, 628);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 23);
            this.label16.TabIndex = 126;
            this.label16.Text = "Estado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(82, 627);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 23);
            this.label17.TabIndex = 125;
            this.label17.Text = "CEP";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Calibri", 12F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbEstado.Location = new System.Drawing.Point(420, 654);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(91, 32);
            this.cmbEstado.TabIndex = 12;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnFechar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(833, 40);
            this.bunifuGradientPanel1.TabIndex = 131;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnFechar.Image = global::Russo2.Properties.Resources.ext;
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(764, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(37, 37);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFechar.TabIndex = 12;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 6;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // telaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(833, 864);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.btnCEP);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaCliente";
            this.Load += new System.EventHandler(this.telaCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Button btnCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mskCNPJ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRetFora;
        private System.Windows.Forms.Label lblRet;
        private System.Windows.Forms.RadioButton rdbRetFora;
        private System.Windows.Forms.RadioButton rdbRet;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtRamoA;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtNfantasia;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSegmento;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private System.Windows.Forms.MaskedTextBox mskInsc;
        private System.Windows.Forms.ComboBox cmbVend;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton rdbInd2;
        private System.Windows.Forms.RadioButton rdbInd1;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox txtEmail;
    }
}