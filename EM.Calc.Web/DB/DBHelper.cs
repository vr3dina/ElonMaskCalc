using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EM.Calc.Web.DB
{
    public class DBHelper
    {
        public static string GetGata(string connectionString)
        {
            string res = "";
           
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(
                    "SELECT Id, UserId, Result, CreationDate, ExecTime FROM OperationResult;",
                    connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        res += string.Format("{0} | {1} | {2} | {3} | {4} \r\n", 
                            reader.GetInt64(0),
                            reader.GetInt64(1),
                            reader.GetFloat(2),
                            reader.GetDateTime(3),
                            reader.GetInt64(4));
                    }
                }
                else
                {
                    res = "No rows found";
                }
                reader.Close();
            }
            return res;
        }
    }
}