namespace Russo2
{
    partial class telaPesVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPesVenda));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alterarProspecçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarResenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnFechar = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbSeg = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(27, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 600);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarProspecçãoToolStripMenuItem,
            this.alterarResenhaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 52);
            // 
            // alterarProspecçãoToolStripMenuItem
            // 
            this.alterarProspecçãoToolStripMenuItem.Name = "alterarProspecçãoToolStripMenuItem";
            this.alterarProspecçãoToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.alterarProspecçãoToolStripMenuItem.Text = "Alterar Prospecção";
            this.alterarProspecçãoToolStripMenuItem.Click += new System.EventHandler(this.alterarProspecçãoToolStripMenuItem_Click);
            // 
            // alterarResenhaToolStripMenuItem
            // 
            this.alterarResenhaToolStripMenuItem.Name = "alterarResenhaToolStripMenuItem";
            this.alterarResenhaToolStripMenuItem.Size = new System.Drawing.Size(203, 24);
            this.alterarResenhaToolStripMenuItem.Text = "Visualizar Resenha";
            this.alterarResenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarResenhaToolStripMenuItem_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Calibri", 18F);
            this.txtBusca.Location = new System.Drawing.Point(27, 62);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(581, 44);
            this.txtBusca.TabIndex = 1;
            // 
            // btnBusca
            // 
            this.btnBusca.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.BorderRadius = 0;
            this.btnBusca.ButtonText = "Buscar";
            this.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusca.DisabledColor = System.Drawing.Color.Gray;
            this.btnBusca.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBusca.Iconimage = null;
            this.btnBusca.Iconimage_right = null;
            this.btnBusca.Iconimage_right_Selected = null;
            this.btnBusca.Iconimage_Selected = null;
            this.btnBusca.IconMarginLeft = 0;
            this.btnBusca.IconMarginRight = 0;
            this.btnBusca.IconRightVisible = true;
            this.btnBusca.IconRightZoom = 0D;
            this.btnBusca.IconVisible = true;
            this.btnBusca.IconZoom = 90D;
            this.btnBusca.IsTab = false;
            this.btnBusca.Location = new System.Drawing.Point(638, 62);
            this.btnBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnBusca.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnBusca.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBusca.selected = false;
            this.btnBusca.Size = new System.Drawing.Size(149, 44);
            this.btnBusca.TabIndex = 2;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBusca.Textcolor = System.Drawing.Color.White;
            this.btnBusca.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1921, 46);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Image = global::Russo2.Properties.Resources.ext;
            this.btnFechar.ImageActive = null;
            this.btnFechar.Location = new System.Drawing.Point(1205, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnFechar.TabIndex = 11;
            this.btnFechar.TabStop = false;
            this.btnFechar.Zoom = 6;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cmbSeg
            // 
            this.cmbSeg.Font = new System.Drawing.Font("Calibri", 18F);
            this.cmbSeg.FormattingEnabled = true;
            this.cmbSeg.Items.AddRange(new object[] {
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
            this.cmbSeg.Location = new System.Drawing.Point(841, 61);
            this.cmbSeg.Name = "cmbSeg";
            this.cmbSeg.Size = new System.Drawing.Size(412, 45);
            this.cmbSeg.TabIndex = 4;
            this.cmbSeg.Text = "Segmento";
            this.cmbSeg.Visible = false;
            // 
            // telaPesVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 746);
            this.Controls.Add(this.cmbSeg);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaPesVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaPesVenda";
            this.Load += new System.EventHandler(this.telaPesVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusca;
        private Bunifu.Framework.UI.BunifuFlatButton btnBusca;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alterarProspecçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarResenhaToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnFechar;
        private System.Windows.Forms.ComboBox cmbSeg;
    }
}