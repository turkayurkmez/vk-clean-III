using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SRP
{
    public class DBOperations
    {
        private SqlConnection sqlConnection;
        public DBOperations(string connectionString)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(connectionString);
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string, object> parameters) 
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText =commandText;

            addParametersToCommand(sqlCommand, parameters);

            sqlCommand.Connection.Open();                   
            var affectedRows = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();

            return affectedRows;
        }

        private void addParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}
