namespace PlanodeAulas.Relatorios
{
    partial class FrmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spBuscarDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planodeAulasDataSet = new PlanodeAulas.PlanodeAulasDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTimerInicial = new System.Windows.Forms.DateTimePicker();
            this.dTimerFinal = new System.Windows.Forms.DateTimePicker();
            this.tblPlanoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPlanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPlanoTableAdapter = new PlanodeAulas.PlanodeAulasDataSetTableAdapters.TblPlanoTableAdapter();
            this.spBuscarDataTableAdapter = new PlanodeAulas.PlanodeAulasDataSetTableAdapters.spBuscarDataTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btFecharRel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planodeAulasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // spBuscarDataBindingSource
            // 
            this.spBuscarDataBindingSource.DataMember = "spBuscarData";
            this.spBuscarDataBindingSource.DataSource = this.planodeAulasDataSet;
            // 
            // planodeAulasDataSet
            // 
            this.planodeAulasDataSet.DataSetName = "PlanodeAulasDataSet";
            this.planodeAulasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spBuscarDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PlanodeAulas.Relatorios.RelAulas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 78);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 396);
            this.reportViewer1.TabIndex = 0;
            // 
            // dTimerInicial
            // 
            this.dTimerInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimerInicial.Location = new System.Drawing.Point(26, 52);
            this.dTimerInicial.Name = "dTimerInicial";
            this.dTimerInicial.Size = new System.Drawing.Size(166, 20);
            this.dTimerInicial.TabIndex = 1;
            this.dTimerInicial.ValueChanged += new System.EventHandler(this.DTimerInicial_ValueChanged);
            // 
            // dTimerFinal
            // 
            this.dTimerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimerFinal.Location = new System.Drawing.Point(241, 52);
            this.dTimerFinal.Name = "dTimerFinal";
            this.dTimerFinal.Size = new System.Drawing.Size(166, 20);
            this.dTimerFinal.TabIndex = 2;
            this.dTimerFinal.ValueChanged += new System.EventHandler(this.DTimerFinal_ValueChanged);
            // 
            // tblPlanoBindingSource1
            // 
            this.tblPlanoBindingSource1.DataMember = "TblPlano";
            this.tblPlanoBindingSource1.DataSource = this.planodeAulasDataSet;
            // 
            // tblPlanoBindingSource
            // 
            this.tblPlanoBindingSource.DataMember = "TblPlano";
            this.tblPlanoBindingSource.DataSource = this.planodeAulasDataSet;
            // 
            // tblPlanoTableAdapter
            // 
            this.tblPlanoTableAdapter.ClearBeforeFill = true;
            // 
            // spBuscarDataTableAdapter
            // 
            this.spBuscarDataTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "RELATÓRIOS POR DATAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Final";
            // 
            // btFecharRel
            // 
            this.btFecharRel.Image = global::PlanodeAulas.Properties.Resources.iconfinder_cross_48_10298;
            this.btFecharRel.Location = new System.Drawing.Point(839, 20);
            this.btFecharRel.Name = "btFecharRel";
            this.btFecharRel.Size = new System.Drawing.Size(56, 52);
            this.btFecharRel.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btFecharRel, "Fechar o Relatório");
            this.btFecharRel.UseVisualStyleBackColor = true;
            this.btFecharRel.Click += new System.EventHandler(this.BtFecharRel_Click);
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 511);
            this.Controls.Add(this.btFecharRel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dTimerFinal);
            this.Controls.Add(this.dTimerInicial);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Plano de Aulas";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spBuscarDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planodeAulasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlanoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PlanodeAulasDataSet planodeAulasDataSet;
        private System.Windows.Forms.BindingSource tblPlanoBindingSource;
        private PlanodeAulasDataSetTableAdapters.TblPlanoTableAdapter tblPlanoTableAdapter;
        private System.Windows.Forms.DateTimePicker dTimerInicial;
        private System.Windows.Forms.DateTimePicker dTimerFinal;
        private System.Windows.Forms.BindingSource tblPlanoBindingSource1;
        private System.Windows.Forms.BindingSource spBuscarDataBindingSource;
        private PlanodeAulasDataSetTableAdapters.spBuscarDataTableAdapter spBuscarDataTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btFecharRel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}