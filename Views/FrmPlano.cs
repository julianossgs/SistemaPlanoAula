using PlanodeAulas.Relatorios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlanodeAulas.Views
{
    public partial class FrmPlano : Form
    {
        PlanoEnt obj = new PlanoEnt();
        public FrmPlano()
        {
            InitializeComponent();
            ListarPlanos();
        }

        private void MsgOK(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void MsgERRO(string msg)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        } 

        private void LimparCampos()
        {
            txtId.Clear();
            txtEixo.Clear();
            txtHora.Clear();
            txtMetodologia.Clear();
            txtAvaliacao.Clear();
            txtConteudo.Clear();
            txtObjetivo.Clear();
        } 

        private void HabilitarCampos(bool vr)
        {
            if (vr==true)
            {
                dTimer1.Focus();
                txtAvaliacao.Enabled = true;
                txtConteudo.Enabled = true;
                txtEixo.Enabled = true;
                txtHora.Enabled = true;
                txtMetodologia.Enabled = true;
                txtObjetivo.Enabled = true;
            }
            else
            {
                txtAvaliacao.Enabled = false;
                txtConteudo.Enabled = false;
                txtEixo.Enabled = false;
                txtHora.Enabled = false;
                txtMetodologia.Enabled = false;
                txtObjetivo.Enabled = false;
            }
        } 

        private void ListarPlanos()
        {
            try
            {
                List<PlanoEnt> lista = new List<PlanoEnt>();
                lista = new PlanoModel().ListarPlanos();
                gridAulas.AutoGenerateColumns = false;
                gridAulas.DataSource = lista;
            }
            catch (Exception ex)
            {

                MsgERRO("Erro ao Listar: " + ex.Message);
            }
        }

        private void BuscarDatas()
        {
            try
            {
                obj.DataInicial = Convert.ToDateTime(dTimerInicial.Value);
                obj.DataFinal = Convert.ToDateTime(dTimerFinal.Value);
                List<PlanoEnt> lista = new List<PlanoEnt>();
                lista = new PlanoModel().BuscarDatas(obj);
                gridAulas.AutoGenerateColumns = false;
                gridAulas.DataSource = lista;
            }
            catch (Exception ex)
            {

                MsgERRO("Erro ao Listar: " + ex.Message);
            }
        }

        //Método dos botões
        public string op = "";
        private void IniciarOp()
        {
            switch (op)
            {
                case "Novo":
                    HabilitarCampos(true);
                    LimparCampos();
                    break;

                case "Salvar":
                    try
                    {
                        //obj.IdPlano = Convert.ToInt32(txtId.Text);
                        obj.Data = Convert.ToDateTime(dTimer1.Text);
                        obj.Hora = txtHora.Text;
                        obj.Eixo = txtEixo.Text;
                        obj.Objetivo = txtObjetivo.Text;
                        obj.Conteudo = txtConteudo.Text;
                        obj.Metodologia = txtMetodologia.Text;
                        obj.Avaliacao = txtAvaliacao.Text;

                        //passando as informações p/ o model
                        int x = PlanoModel.Inserir(obj);

                        //verificar se a inserção foi feita
                        if (x > 0)
                        {
                            MsgOK(string.Format("Plano de Aulas inserido com sucesso!"));
                        }
                        else
                        {
                            MsgERRO("Não foi possível Inserir!");
                        }
                    }
                    catch (Exception ex)
                    {

                        MsgERRO("Erro ao Inserir: " + ex.Message+ex.StackTrace);
                    }
                    break;

                case "Editar":
                    try
                    {
                        obj.IdPlano = Convert.ToInt32(txtId.Text);
                        obj.Data = Convert.ToDateTime(dTimer1.Text);
                        obj.Hora = txtHora.Text;
                        obj.Eixo = txtEixo.Text;
                        obj.Objetivo = txtObjetivo.Text;
                        obj.Conteudo = txtConteudo.Text;
                        obj.Metodologia = txtMetodologia.Text;
                        obj.Avaliacao = txtAvaliacao.Text;

                        //passando as informações p/ o model
                        int x = PlanoModel.Alterar(obj);

                        //verificar se a alteração foi feita
                        if (x > 0)
                        {
                            MsgOK(string.Format("Plano de Aulas alterado com sucesso!"));
                        }
                        else
                        {
                            MsgERRO("Não foi possível Alterar!");
                        }
                    }
                    catch (Exception ex)
                    {

                        MsgERRO("Erro ao Alterar: " + ex.Message+ex.StackTrace);
                    }

                    break;

                case "Cancelar":
                    LimparCampos();
                    HabilitarCampos(true);
                    break;

                case "Excluir":
                    try
                    {
                        obj.IdPlano = Convert.ToInt32(txtId.Text);
                     
                        //passando as informações p/ o model
                        int x = PlanoModel.Excluir(obj);

                        //verificar se a inserção foi feita
                        if (x > 0)
                        {
                            MsgOK(string.Format("Plano de Aulas excluído com sucesso!"));
                        }
                        else
                        {
                            MsgERRO("Não foi possível Excluír!");
                        }
                    }
                    catch (Exception ex)
                    {

                        MsgERRO("Erro ao Excluir: " + ex.Message+ex.StackTrace);
                    }

                    break;


                default:
                    break;
            }
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            op = "Novo";
            IniciarOp();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (txtHora.Text==string.Empty)
            {
                MsgERRO("Insira um Plano de Aulas!");
                return;
            }
            op = "Salvar";
            IniciarOp();
            LimparCampos();
            ListarPlanos();
            HabilitarCampos(true);
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            if (txtHora.Text == string.Empty)
            {
                MsgERRO("Selecione um Plano de Aulas para Alterar!");
                return;
            }
            op = "Editar";
            IniciarOp();
            LimparCampos();
            ListarPlanos();
            HabilitarCampos(true);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            op = "Cancelar";
            IniciarOp();
            HabilitarCampos(true);
            LimparCampos();
            ListarPlanos();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (txtHora.Text == string.Empty)
            {
                MsgERRO("Selecione um Plano de Aulas para Excluír!");
                return;
            }
            if (MessageBox.Show("Deseja Excluír??", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No) 
            {
                return;
            }
            op = "Excluir";
            IniciarOp();
            LimparCampos();
            ListarPlanos();
            HabilitarCampos(true);
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridAulas_DoubleClick(object sender, EventArgs e)
        {
            txtId.Text = Convert.ToString(gridAulas.CurrentRow.Cells["IdPlano"].Value);
            dTimer1.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Data"].Value);
            txtHora.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Hora"].Value);
            txtEixo.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Eixo"].Value);
            txtObjetivo.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Objetivo"].Value);
            txtConteudo.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Conteudo"].Value);
            txtMetodologia.Text =Convert.ToString(gridAulas.CurrentRow.Cells["Metodologia"].Value);
            txtAvaliacao.Text = Convert.ToString(gridAulas.CurrentRow.Cells["Avaliacao"].Value);
            tabControl1.SelectedIndex = 0;
            HabilitarCampos(true);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DTimer1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DTimerInicial_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }

        private void DTimerFinal_ValueChanged(object sender, EventArgs e)
        {
            BuscarDatas();
        }

        private void BtBuscarDatas_Click(object sender, EventArgs e)
        {
           // BuscarDatas();
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
            FrmRelatorio frmRelatorio = new FrmRelatorio();
            frmRelatorio.ShowDialog();
        }
    }
}
