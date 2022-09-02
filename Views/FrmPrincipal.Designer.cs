namespace PlanodeAulas.Views
{
    partial class FrmPrincipal
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
            this.btInsira = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btInsira
            // 
            this.btInsira.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btInsira.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsira.Location = new System.Drawing.Point(12, 12);
            this.btInsira.Name = "btInsira";
            this.btInsira.Size = new System.Drawing.Size(276, 81);
            this.btInsira.TabIndex = 0;
            this.btInsira.Text = "Insira seu Plano de Aulas";
            this.btInsira.UseVisualStyleBackColor = false;
            this.btInsira.Click += new System.EventHandler(this.BtInsira_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSair.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(12, 116);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(204, 81);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair do Sistema";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(798, 522);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(76, 30);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlanodeAulas.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btInsira);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsira;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}