using MySql.Data.MySqlClient;
using Projeto_Login_MySQL.Code.BLL;
using Projeto_Login_MySQL.Code.DTO;
using Projeto_Login_MySQL.Code.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Login_MySQL
{
    public partial class FormLogin : Form
    {
        UsuarioBLL bll = new UsuarioBLL();
        UsuarioDTO dto = new UsuarioDTO();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            MySqlDataReader dataReader;

            dto.Nome_usuario = textBoxNomeUsuario.Text;
            dto.Senha_usuario = textBoxSenha.Text;
            dataReader = bll.BuscarRegistro(dto);

            if (dataReader.HasRows)
            {
                Thread novaThread = new Thread(new ThreadStart(novoForm));
                novaThread.SetApartmentState(ApartmentState.STA);
                novaThread.Start();
                this.Close();
            }
            else
            {
                DialogResult result = MessageBox.Show(this, "Login inválido \n Deseja tentar novamente?",
                                   "Error", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1, 0);

                if (result == DialogResult.Yes)
                {
                    textBoxNomeUsuario.Clear();
                    textBoxSenha.Clear();
                    textBoxNomeUsuario.Focus();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void novoForm()
        {
            Application.Run(new FormPrincipal());
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
