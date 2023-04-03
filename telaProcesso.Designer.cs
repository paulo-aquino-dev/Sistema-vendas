namespace Russo2
{
    partial class telaProcesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaProcesso));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCarrega = new System.Windows.Forms.Label();
            this.pgbSplash = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCarrega
            // 
            this.lblCarrega.AutoSize = true;
            this.lblCarrega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrega.ForeColor = System.Drawing.Color.Green;
            this.lblCarrega.Location = new System.Drawing.Point(243, 252);
            this.lblCarrega.Name = "lblCarrega";
            this.lblCarrega.Size = new System.Drawing.Size(61, 24);
            this.lblCarrega.TabIndex = 1;
            this.lblCarrega.Text = "label1";
            // 
            // pgbSplash
            // 
            this.pgbSplash.animated = false;
            this.pgbSplash.animationIterval = 5;
            this.pgbSplash.animationSpeed = 300;
            this.pgbSplash.BackColor = System.Drawing.Color.Transparent;
            this.pgbSplash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgbSplash.BackgroundImage")));
            this.pgbSplash.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.pgbSplash.ForeColor = System.Drawing.Color.Green;
            this.pgbSplash.LabelVisible = true;
            this.pgbSplash.LineProgressThickness = 8;
            this.pgbSplash.LineThickness = 5;
            this.pgbSplash.Location = new System.Drawing.Point(179, 18);
            this.pgbSplash.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.pgbSplash.MaxValue = 100;
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.ProgressBackColor = System.Drawing.Color.DimGray;
            this.pgbSplash.ProgressColor = System.Drawing.Color.Green;
            this.pgbSplash.Size = new System.Drawing.Size(225, 225);
            this.pgbSplash.TabIndex = 2;
            this.pgbSplash.UseWaitCursor = true;
            this.pgbSplash.Value = 0;
            // 
            // telaProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 316);
            this.Controls.Add(this.pgbSplash);
            this.Controls.Add(this.lblCarrega);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaProcesso";
            this.Load += new System.EventHandler(this.telaProcesso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCarrega;
        private Bunifu.Framework.UI.BunifuCircleProgressbar pgbSplash;
    }
}