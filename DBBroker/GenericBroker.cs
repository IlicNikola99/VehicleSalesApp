using Common.Domain;
using Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Common.Helpers;

namespace DBBroker
{
    public class GenericBroker : IBroker
    {
        private DbConnection connection;
        public GenericBroker()
        {
            connection = new DbConnection();
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public IEntity Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            obj.GenerateNewId();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.InsertValues} )";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return obj;
        }

        public IEntity GetOne(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT * FROM {obj.TableName} WHERE {obj.WhereClause}";
            SqlDataReader reader = command.ExecuteReader();
            IEntity result = null;

            try
            {
                command.Dispose();
                while (reader.Read())
                {
                   result = obj.ReadObjectRow(reader);
                }
                return result;
            }
            finally
            {
                reader.Close();
            }
        }

        public List<IEntity> GetAll(IEntity obj)
        {
            List<IEntity> result = new List<IEntity>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT {obj.SelectValues} FROM {obj.TableName} {obj.TableAlias} {obj.JoinClause}  {obj.OrderByClause} ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        IEntity rowObject = obj.ReadObjectRow(reader);
                        result.Add(rowObject);
                    }
                }
                finally
                {
                    reader.Close();
                }
            }
            return result;
        }

        public List<IEntity> Search(IEntity obj)
        {
            List<IEntity> result = new List<IEntity>();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT {obj.SearchValues} FROM {obj.TableName} {obj.TableAlias} {obj.JoinClause} WHERE {obj.SearchWhereClause} {obj.OrderByClause} ";
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    IEntity rowObject = obj.ReadObjectRowSearch(reader);
                    result.Add(rowObject);
                }
            }
            return result;
        }

        public void Delete(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"DELETE FROM {obj.TableName} WHERE {obj.DeleteWhereClause}";
            command.ExecuteNonQuery();
        }

        public void Update(IEntity obj)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"UPDATE {obj.TableName} SET {obj.UpdateValues} WHERE {obj.WhereClause}";
            command.ExecuteNonQuery();
        }
    }
}
