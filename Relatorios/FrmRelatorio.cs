using System;
using System.Windows.Forms;

namespace PlanodeAulas.Relatorios
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
          
        }

       
        private void DTimerInicial_ValueChanged(object sender, EventArgs e)
        {
            this.spBuscarDataTableAdapter.Fill(this.planodeAulasDataSet.spBuscarData,dTimerInicial.Value,dTimerFinal.Value);

            this.reportViewer1.RefreshReport();
        }

        private void DTimerFinal_ValueChanged(object sender, EventArgs e)
        {
            this.spBuscarDataTableAdapter.Fill(this.planodeAulasDataSet.spBuscarData,dTimerInicial.Value,dTimerFinal.Value);

            this.reportViewer1.RefreshReport();
        }

        private void BtFecharRel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
