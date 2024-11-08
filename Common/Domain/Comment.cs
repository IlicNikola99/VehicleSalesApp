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

        public string InsertValues => $"'{Id}','{UserId}', '{AdvertisementId}','{Text}', '{CreatedOn}'";

        public string TableAlias => throw new NotImplementedException();

        public string InsertColumns => "";

        public string SelectValues => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string WhereClause => throw new NotImplementedException();

        public string JoinClause => throw new NotImplementedException();

        public string SearchValues => throw new NotImplementedException();

        public string SearchWhereClause => throw new NotImplementedException();

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public List<IEntity> GetAll(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
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
