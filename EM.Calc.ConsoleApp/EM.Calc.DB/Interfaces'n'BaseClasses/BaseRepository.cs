using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace EM.Calc.DB
{
    public class BaseRepository<T> : IEntityRepository<T> where T : class, IEntity
    {
        private string connectionString;

        public BaseRepository(string connection)
        {
            connectionString = connection;

            var type = typeof(T);
            Fields = string.Join(",", type.GetProperties().Select(n => n.Name));
            TableName = type.Name;
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public void Delete(long id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(
                    $"DELETE FROM {TableName} WHERE Id = {id}",
                    connection);
                sqlCommand.ExecuteNonQuery();

                connection.Close();
            }
        }

        public virtual string TableName { get; set; }

        public virtual string Fields { get; set; }

        public IEnumerable<T> GetAll()
        {
            return Load($"SELECT {Fields} FROM {TableName}");
        }

        public T Load(long id)
        {
            IEnumerable<T> res = Load($"SELECT {Fields} FROM {TableName} WHERE Id = {id}");

            if (res.Count<T>() > 0)
                return res.ElementAt(0);
            else
                return null;
        }

        private IEnumerable<T> Load(string sqlCommand)
        {
            List<T> result = new List<T>();
            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlCommand, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var obj = Create();
                        var type = typeof(T);
                        var props = type.GetProperties();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var column = reader.GetName(i);
                            var prop = props.FirstOrDefault(p => p.Name == column);
                            if (prop != null)
                            {
                                prop.SetValue(obj, reader[i]);
                            }
                        }
                        result.Add(obj);
                    }
                }
                reader.Close();
            }
            return result;
        }

        public void Update(T entity)
        {
        }
    }
}
