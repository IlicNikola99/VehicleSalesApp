using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class User : BaseEntity, IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public string TableName => "[User]";

        public string Values => $"'{Id}','{Username}', '{Password}','{FirstName}', '{LastName}', '{Address}', '{City}', '{PhoneNumber}', '{CreatedOn}'";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
