using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Login_MySQL.Code.DAL
{
    class AcessarBancoDados
    {
        private MySqlConnection conn;

        private string myServer = "srv848.hstgr.io";
        private string myUser = "u269685050_root";
        private string myPass = "VisualStudio2019";
        private string myDatabase = "u269685050_bauxita";

        public void Conectar()
        {
            if (conn != null)
                conn.Close();

            string connStr = $"server={myServer}; uid={myUser}; pwd={myPass}; database={myDatabase}";

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch(Exception ex)
            {
                throw new Exception("Não foi possível conectar ao servidor de banco de dados: " + ex.Message);
            }
        }

        public void ExecutarComandoSQL(string comandoSQL)
        {
            MySqlCommand cmd = new MySqlCommand(comandoSQL, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable BuscarDataTable(string comandoSQL)
        {
            DataTable dataTable = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(comandoSQL, conn);
            dataAdapter.Fill(dataTable);

            return dataTable;
        }

        public MySqlDataReader BuscarDataReader(string comandoSQL)
        {
            MySqlCommand cmd = new MySqlCommand(comandoSQL, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            return dataReader;
        }
    }
}
