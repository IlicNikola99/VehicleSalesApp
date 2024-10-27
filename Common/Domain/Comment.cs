using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class Comment :BaseEntity, IEntity
    {
        public Comment()
        {
            this.Id = Guid.Empty;
            this.CreatedOn = DateTime.Now;
        }

        public Guid UserId { get; set; }
        public Guid AdvertisementId{ get; set; }
        public string Text { get; set; }
      
        public string TableName => "[Comment]";

        public string Values => $"'{Id}','{UserId}', '{AdvertisementId}','{Text}', '{CreatedOn}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    public class CommentView
    {
        public string Username { get; set; }
        public string Text { get; set; }

    }
}
