using MySql.Data.MySqlClient;
using Projeto_Login_MySQL.Code.DAL;
using Projeto_Login_MySQL.Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Login_MySQL.Code.BLL
{
    class UsuarioBLL
    {
        AcessarBancoDados bd;

        public void Inserir()
        {

        }

        public MySqlDataReader BuscarRegistro(UsuarioDTO dto)
        {
            MySqlDataReader dataReader;

            try
            {
                bd = new AcessarBancoDados();
                bd.Conectar();

                string comandoSQL = $"SELECT `login_usuario`,`senha_usuario` FROM `tabela_usuarios` WHERE `login_usuario` = '{dto.Nome_usuario}' AND `senha_usuario` = '{dto.Senha_usuario}';";
                dataReader = bd.BuscarDataReader(comandoSQL);
                return dataReader;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro!" + ex.Message);
            }
            finally
            {
                bd = null;
            }
        }
    }
}
