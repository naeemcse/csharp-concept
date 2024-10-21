using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetExample
{
    public class AdonetUtility
    {
        private readonly string _connectionString = "Server=DESKTOP-8DI1SVB\\SQLEXPRESS;Database=CSharpB18;User Id=csharpb18;Password=123456; Trust Server Certificate=True ";
        public void RunSql(string sql)
        {
            SqlConnection sqlConnection= new SqlConnection(_connectionString);
            SqlCommand sqlCommand= new SqlCommand(sql,sqlConnection);

            if(sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();


            int rowExpected = sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            sqlConnection.Dispose();
            sqlCommand.Dispose();

        }
    }
}
