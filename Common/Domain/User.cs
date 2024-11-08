using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;


namespace Common.Domain
{
    [Serializable]
    public class User : BaseEntity, IEntity
    {
        public User()
        {
            this.Id = Guid.Empty;
            this.CreatedOn= DateTime.Now;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableName => "[User]";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertValues => $"'{Id}','{Username}', '{Password}','{FirstName}', '{LastName}', '{Address}', '{City}', '{PhoneNumber}', '{CreatedOn}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableAlias => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertColumns => "";

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

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            User other = obj as User;

            return this.Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            User user = new User
            {
                Id = (Guid)reader["id"],
                Username = (string)reader["username"],
                Password = (string)reader["password"],
                FirstName = (string)reader["firstname"],
                LastName = (string)reader["lastname"],
                Address = (string)reader["address"],
                City = (string)reader["city"],
                PhoneNumber = (string)reader["phonenumber"],
                CreatedOn = (DateTime)reader["createdon"]
            };
            return user;
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
