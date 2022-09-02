namespace PlanodeAulas.Views
{
    partial class FrmPlano
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.dTimer1 = new System.Windows.Forms.DateTimePicker();
            this.txtAvaliacao = new System.Windows.Forms.TextBox();
            this.txtMetodologia = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.txtEixo = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridAulas = new System.Windows.Forms.DataGridView();
            this.IdPlano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eixo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Conteudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metodologia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avaliacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btImprimir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dTimerFinal = new System.Windows.Forms.DateTimePicker();
            this.dTimerInicial = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAulas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btFechar);
            this.tabPage1.Controls.Add(this.btExcluir);
            this.tabPage1.Controls.Add(this.btCancelar);
            this.tabPage1.Controls.Add(this.btEditar);
            this.tabPage1.Controls.Add(this.btSalvar);
            this.tabPage1.Controls.Add(this.btNovo);
            this.tabPage1.Controls.Add(this.dTimer1);
            this.tabPage1.Controls.Add(this.txtAvaliacao);
            this.tabPage1.Controls.Add(this.txtMetodologia);
            this.tabPage1.Controls.Add(this.txtConteudo);
            this.tabPage1.Controls.Add(this.txtObjetivo);
            this.tabPage1.Controls.Add(this.txtEixo);
            this.tabPage1.Controls.Add(this.txtHora);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inserir Plano de Aulas";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(138, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 26);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cód Plano de Aulas";
            // 
            // btFechar
            // 
            this.btFechar.Image = global::PlanodeAulas.Properties.Resources.iconfinder_40_Close_Switch_Off_Power_Switcher_Button_2142692;
            this.btFechar.Location = new System.Drawing.Point(642, 374);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(67, 60);
            this.btFechar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btFechar, "Fechar ");
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Image = global::PlanodeAulas.Properties.Resources.botaoDeletar;
            this.btExcluir.Location = new System.Drawing.Point(555, 374);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(67, 60);
            this.btExcluir.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btExcluir, "Excluir Plano de Aulas");
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.BtExcluir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Image = global::PlanodeAulas.Properties.Resources.iconfinder_ic_remove_circle_outline_48px_352442;
            this.btCancelar.Location = new System.Drawing.Point(468, 374);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(67, 60);
            this.btCancelar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btCancelar, "Cancelar Plano de Aulas");
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Image = global::PlanodeAulas.Properties.Resources.botaoEditar;
            this.btEditar.Location = new System.Drawing.Point(381, 376);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(67, 60);
            this.btEditar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btEditar, "Editar Plano de Aulas");
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Image = global::PlanodeAulas.Properties.Resources.botaoSalvar;
            this.btSalvar.Location = new System.Drawing.Point(294, 376);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(67, 60);
            this.btSalvar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btSalvar, "Salvar Plano de Aulas");
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // btNovo
            // 
            this.btNovo.Image = global::PlanodeAulas.Properties.Resources.botaoNovo;
            this.btNovo.Location = new System.Drawing.Point(207, 374);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(67, 65);
            this.btNovo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btNovo, "Novo Plano de Aulas");
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.BtNovo_Click);
            // 
            // dTimer1
            // 
            this.dTimer1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimer1.Location = new System.Drawing.Point(667, 15);
            this.dTimer1.Name = "dTimer1";
            this.dTimer1.Size = new System.Drawing.Size(121, 21);
            this.dTimer1.TabIndex = 1;
            this.dTimer1.ValueChanged += new System.EventHandler(this.DTimer1_ValueChanged);
            // 
            // txtAvaliacao
            // 
            this.txtAvaliacao.Enabled = false;
            this.txtAvaliacao.Location = new System.Drawing.Point(140, 304);
            this.txtAvaliacao.MaxLength = 300;
            this.txtAvaliacao.Multiline = true;
            this.txtAvaliacao.Name = "txtAvaliacao";
            this.txtAvaliacao.Size = new System.Drawing.Size(648, 50);
            this.txtAvaliacao.TabIndex = 7;
            // 
            // txtMetodologia
            // 
            this.txtMetodologia.Enabled = false;
            this.txtMetodologia.Location = new System.Drawing.Point(140, 226);
            this.txtMetodologia.MaxLength = 300;
            this.txtMetodologia.Multiline = true;
            this.txtMetodologia.Name = "txtMetodologia";
            this.txtMetodologia.Size = new System.Drawing.Size(648, 55);
            this.txtMetodologia.TabIndex = 6;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Enabled = false;
            this.txtConteudo.Location = new System.Drawing.Point(140, 181);
            this.txtConteudo.MaxLength = 200;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(648, 21);
            this.txtConteudo.TabIndex = 5;
            // 
            // txtObjetivo
            // 
            this.txtObjetivo.Enabled = false;
            this.txtObjetivo.Location = new System.Drawing.Point(140, 134);
            this.txtObjetivo.MaxLength = 200;
            this.txtObjetivo.Name = "txtObjetivo";
            this.txtObjetivo.Size = new System.Drawing.Size(648, 21);
            this.txtObjetivo.TabIndex = 4;
            // 
            // txtEixo
            // 
            this.txtEixo.Enabled = false;
            this.txtEixo.Location = new System.Drawing.Point(140, 94);
            this.txtEixo.MaxLength = 100;
            this.txtEixo.Name = "txtEixo";
            this.txtEixo.Size = new System.Drawing.Size(648, 21);
            this.txtEixo.TabIndex = 3;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(140, 54);
            this.txtHora.MaxLength = 50;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(242, 21);
            this.txtHora.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Avaliação";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Metodologia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Conteúdo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Objetivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.gridAulas);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Plano de Aulas";
            // 
            // gridAulas
            // 
            this.gridAulas.AllowUserToAddRows = false;
            this.gridAulas.AllowUserToDeleteRows = false;
            this.gridAulas.AllowUserToOrderColumns = true;
            this.gridAulas.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridAulas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAulas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPlano,
            this.Data,
            this.Hora,
            this.Eixo,
            this.Objetivo,
            this.Conteudo,
            this.Metodologia,
            this.Avaliacao});
            this.gridAulas.Location = new System.Drawing.Point(16, 116);
            this.gridAulas.MultiSelect = false;
            this.gridAulas.Name = "gridAulas";
            this.gridAulas.ReadOnly = true;
            this.gridAulas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridAulas.RowTemplate.Height = 27;
            this.gridAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAulas.Size = new System.Drawing.Size(842, 304);
            this.gridAulas.TabIndex = 1;
            this.gridAulas.DoubleClick += new System.EventHandler(this.GridAulas_DoubleClick);
            // 
            // IdPlano
            // 
            this.IdPlano.DataPropertyName = "IdPlano";
            dataGridViewCellStyle1.Format = "#,##0";
            this.IdPlano.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdPlano.HeaderText = "Id";
            this.IdPlano.Name = "IdPlano";
            this.IdPlano.ReadOnly = true;
            this.IdPlano.Visible = false;
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Data.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.Width = 90;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Hora.Width = 150;
            // 
            // Eixo
            // 
            this.Eixo.DataPropertyName = "Eixo";
            this.Eixo.HeaderText = "Eixo";
            this.Eixo.Name = "Eixo";
            this.Eixo.ReadOnly = true;
            this.Eixo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eixo.Width = 230;
            // 
            // Objetivo
            // 
            this.Objetivo.DataPropertyName = "Objetivo";
            this.Objetivo.HeaderText = "Objetivo";
            this.Objetivo.Name = "Objetivo";
            this.Objetivo.ReadOnly = true;
            this.Objetivo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Objetivo.Width = 300;
            // 
            // Conteudo
            // 
            this.Conteudo.DataPropertyName = "Conteudo";
            this.Conteudo.HeaderText = "Conteúdo";
            this.Conteudo.Name = "Conteudo";
            this.Conteudo.ReadOnly = true;
            this.Conteudo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Conteudo.Width = 300;
            // 
            // Metodologia
            // 
            this.Metodologia.DataPropertyName = "Metodologia";
            this.Metodologia.HeaderText = "Metodologia";
            this.Metodologia.Name = "Metodologia";
            this.Metodologia.ReadOnly = true;
            this.Metodologia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Metodologia.Width = 300;
            // 
            // Avaliacao
            // 
            this.Avaliacao.DataPropertyName = "Avaliacao";
            this.Avaliacao.HeaderText = "Avaliação";
            this.Avaliacao.Name = "Avaliacao";
            this.Avaliacao.ReadOnly = true;
            this.Avaliacao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Avaliacao.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btImprimir);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dTimerFinal);
            this.panel1.Controls.Add(this.dTimerInicial);
            this.panel1.Location = new System.Drawing.Point(16, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 91);
            this.panel1.TabIndex = 0;
            // 
            // btImprimir
            // 
            this.btImprimir.Image = global::PlanodeAulas.Properties.Resources.iconfinder_Print_1493286;
            this.btImprimir.Location = new System.Drawing.Point(725, 37);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(76, 47);
            this.btImprimir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btImprimir, "Imprima seu Plano de Aulas");
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.BtImprimir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Informe a Data Final";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Informe a Data Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "CONSULTA POR DATAS";
            // 
            // dTimerFinal
            // 
            this.dTimerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimerFinal.Location = new System.Drawing.Point(313, 63);
            this.dTimerFinal.Name = "dTimerFinal";
            this.dTimerFinal.Size = new System.Drawing.Size(166, 21);
            this.dTimerFinal.TabIndex = 1;
            this.dTimerFinal.ValueChanged += new System.EventHandler(this.DTimerFinal_ValueChanged);
            // 
            // dTimerInicial
            // 
            this.dTimerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimerInicial.Location = new System.Drawing.Point(66, 63);
            this.dTimerInicial.Name = "dTimerInicial";
            this.dTimerInicial.Size = new System.Drawing.Size(166, 21);
            this.dTimerInicial.TabIndex = 0;
            this.dTimerInicial.ValueChanged += new System.EventHandler(this.DTimerInicial_ValueChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // FrmPlano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmPlano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAulas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView gridAulas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.DateTimePicker dTimer1;
        private System.Windows.Forms.TextBox txtAvaliacao;
        private System.Windows.Forms.TextBox txtMetodologia;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.TextBox txtEixo;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTimerFinal;
        private System.Windows.Forms.DateTimePicker dTimerInicial;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPlano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eixo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Conteudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metodologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avaliacao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btImprimir;
    }
}