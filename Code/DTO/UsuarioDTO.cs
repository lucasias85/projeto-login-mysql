using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Login_MySQL.Code.DTO
{
    class UsuarioDTO
    {
        private string nome_usuario;
        private string email_usuario;
        private string nomecompleto_usuario;
        private string senha_usuario;

        public string Nome_usuario { get => nome_usuario; set => nome_usuario = value; }
        public string Email_usuario { get => email_usuario; set => email_usuario = value; }
        public string Nomecompleto_usuario { get => nomecompleto_usuario; set => nomecompleto_usuario = value; }
        public string Senha_usuario { get => senha_usuario; set => senha_usuario = value; }
    }
}
