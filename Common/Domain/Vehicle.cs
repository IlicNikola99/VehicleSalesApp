using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;


namespace Common.Domain
{
    [Serializable]
    public class Vehicle : BaseEntity, IEntity
    {
        public Vehicle()
        {
            this.Id = Guid.Empty;
            this.CreatedOn = DateTime.Now;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public BodyType BodyType { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableName => "[Vehicle]";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertValues => $"'{Id}','{Make}', '{Model}','{BodyType}','{CreatedOn}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableAlias => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string OrderByClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SelectValues => "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string UpdateValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string WhereClause => $"id = '{this.Id}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string JoinClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchWhereClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string DeleteWhereClause => "";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Vehicle v = new Vehicle
            {
                Id = (Guid)reader["id"],
                Make = (string)reader["make"],
                Model = (string)reader["model"],
                BodyType = (BodyType)Enum.Parse(typeof(BodyType), (string)reader["bodyType"]),
                CreatedOn = (DateTime)reader["CreatedOn"]
            };
            return v;
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);   
        }
    }
}
