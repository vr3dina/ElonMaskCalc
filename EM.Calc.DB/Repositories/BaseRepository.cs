using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace EM.Calc.DB
{
    public class BaseRepository<T> : IEntityRepository<T> where T : class, IEntity
    {
        protected string connectionString;
        protected IEnumerable<PropertyInfo> properties;
        public string TableName;

        public BaseRepository(string connection, string tableName) : this(connection)
        {
            TableName = tableName;
        }

        public BaseRepository(string connection)
        {
            connectionString = connection;

            var type = typeof(T);
            properties = type.GetProperties();
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


        public IEnumerable<T> GetAll()
        {
            var Fields = string.Join(",", properties.Select(p => p.Name));
            return Load($"SELECT {Fields} FROM [{TableName}]");
        }

        public T Load(long id)
        {
            var Fields = string.Join(",", properties.Select(p => p.Name));
            IEnumerable<T> res = Load($"SELECT {Fields} FROM [{TableName}] WHERE Id = {id}");

            if (res.Count<T>() > 0)
                return res.ElementAt(0);
            else
                return null;
        }

        protected IEnumerable<T> Load(string sqlCommand)
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

        protected string GetSqlValue(PropertyInfo propertyInfo, object obj)
        {
            var propertyValue = propertyInfo.GetValue(obj);
            var sqlValue = "";
            if (propertyValue == null)
            {
                sqlValue = "NULL";
            }
            else if (propertyValue is string)
            {
                sqlValue = $"N'{propertyValue}'";
            }
            else if (propertyValue is double)
            {
                var doubleValue = (double)propertyValue;
                sqlValue = $"{doubleValue.ToString(CultureInfo.InvariantCulture)}";
            }
            else if (propertyValue is DateTime)
            {
                var dateTimeValue = (DateTime)propertyValue;
                sqlValue = $"N'{dateTimeValue.ToString(CultureInfo.InvariantCulture)}'";
            }
            else if (propertyValue.GetType().IsEnum)
            {
                var enumValue = (int)propertyValue;
                sqlValue = $"{enumValue}";
            }
            else
            {
                sqlValue = $"{propertyValue}";
            }
            return sqlValue;
        }

        protected int Update(T entity)
        {
            var fields = new List<string>();
            foreach (var prop in properties)
            {
                fields.Add($"[{prop.Name}] = {GetSqlValue(prop, entity)}");
            }

            if (fields.Any())
            {
                var setSQL = string.Join(",", fields);
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        $"UPDATE {TableName} {setSQL} WHERE Id = {entity.Id};",
                        connection);
                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
            return 0;
        }

        protected int Insert(T entity)
        {
            var columnValues = new List<string>();
            var columnNames = new List<string>();
            foreach (var prop in properties)
            {
                if (prop.Name != "Id")
                {
                    columnNames.Add($"[{prop.Name}]");
                    columnValues.Add($"{GetSqlValue(prop, entity)}");
                }
            }

            if (columnNames.Any())
            {
                var columnNamesSQL = string.Join(",", columnNames);
                var columnValuesSQL = string.Join(",", columnValues);
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(
                        $"INSERT INTO {TableName} ({columnNamesSQL}) VALUES ({columnValuesSQL});",
                        connection);
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
            return 0;
        }

        public virtual void Save(T entity)
        {
            if (entity.Id > 0)
            {
                if (Update(entity) == 1)
                {
                    // all good
                }
                else
                {
                    // error
                }
            }
            else
            {
                if (Insert(entity) == 1)
                {
                    //all good
                }
                else
                {
                    // error
                }
            }
        }
    }
}

