using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Advertisement : BaseEntity, IEntity
    {
        public Advertisement()
        {
            this.Id = Guid.Empty;
            this.CreatedOn = DateTime.Now;
        }
        public User User { get; set; }
        public Vehicle Vehicle { get; set; }
        public decimal Price { get; set; }
        public bool AcceptsExchange { get; set; }
        public string Description { get; set; }
        public List<Image> Images { get; set; }
        public string TableName => "[Advertisement]";
        public string Values => $"'{Id}','{User.Id}', '{Vehicle.Id}','{Price}', '{AcceptsExchange}', '{Description}', '{CreatedOn}'";

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
