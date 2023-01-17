using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEntity.Infra.Data.DbConfig
{
    public class ConexaoSQL
    {
        protected SqlConnection sqlConnection; //conexão com banco de dados
        protected SqlCommand sqlCommand; //executada comandos SQL
        protected SqlDataReader sqlDataReader; // Ler dados das consultas ao banco 
        protected SqlTransaction sqlTransaction; //Transações em banco de dados (commit/rollback)

        protected void OpenConnection(string strConnect)
        {
            sqlConnection.ConnectionString = "";
            sqlConnection.Open(); //abertura da conexao com o banco
        }

        protected void CloseConnection()
        {
            sqlConnection.Close(); //fechamento da conexão com o banco 
        }
    }
}
