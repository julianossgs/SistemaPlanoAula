using System;
using System.Windows.Forms;

namespace PlanodeAulas.Views
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
        }

        private void BtInsira_Click(object sender, EventArgs e)
        {
            FrmPlano frmPlano = new FrmPlano();
            frmPlano.ShowDialog();
        }


        private void BtSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }
    }
}
