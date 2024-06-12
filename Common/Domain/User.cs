using System;
using System.Collections.Generic;
using System.Data.SqlClient;


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

        public string TableName => "[User]";

        public string Values => $"'{Id}','{Username}', '{Password}','{FirstName}', '{LastName}', '{Address}', '{City}', '{PhoneNumber}', '{CreatedOn}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
