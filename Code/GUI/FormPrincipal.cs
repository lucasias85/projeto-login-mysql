using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Login_MySQL.Code.GUI
{
    public partial class FormPrincipal : Form
    {
        private Form activeForm;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void AbriFormFilho(Form formFilho)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(formFilho);
            this.panelDesktop.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
            labelTitulo.Text = formFilho.Text;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonHome.Top;
        }

        private void buttonPlanejamento_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonPlanejamento.Top;
        }

        private void buttonFluxo_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonFluxo.Top;
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonCartao.Top;
        }

        private void buttonEmprestimo_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonEmprestimo.Top;
        }
        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            panelSelecao.Top = buttonUsuario.Top;
            AbriFormFilho(new FormUsuario());
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult fechar = MessageBox.Show("Você está prestes a fechar seu programa \n Deseja realmente encerrar sua aplicação?",
                                                  "Encerrando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 0);

            if (fechar == DialogResult.Yes)
                Application.Exit();
        }

        
    }
}
