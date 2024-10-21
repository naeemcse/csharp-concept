using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Dictionary<string, object>> GetData(string sql)
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);

            if (sqlConnection.State != System.Data.ConnectionState.Open)
                sqlConnection.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            List<Dictionary<string, object>> resultt = new List<Dictionary<string, object>>();
            while (reader.Read())
            {
                Dictionary<string,object> row = new Dictionary<string,object>();                                                    
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    var columnValue = reader.GetValue(i);

                    if (columnValue != null) {
                    
                        row.Add(columnName, columnValue );
                    }
                }
               resultt.Add(row);

                /*int id = (int)reader["id"];
                string name = (string)reader["name"];
                DateTime dateofbirth = (DateTime)reader["dateofbirth"];
                bool ismarried = (bool)reader["ismarried"];*/

            }
            return resultt;
                

        }

    }
}
