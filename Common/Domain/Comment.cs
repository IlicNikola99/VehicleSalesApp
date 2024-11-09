using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

        public string Username { get; set; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableName => "[Comment]";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertValues => $"'{Id}','{UserId}', '{AdvertisementId}','{Text}', '{CreatedOn}'";


        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableAlias => "c";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string OrderByClause => $"order by {TableAlias}.CreatedOn desc";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SelectValues => "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string UpdateValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string WhereClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string JoinClause => "join [User] u on c.UserId = u.id";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchValues => "u.Username, c.Text";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchWhereClause => $"c.advertisementId = '{AdvertisementId}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
        {
            Comment comment = new Comment()
            {
                Username = reader["Username"].ToString(),
                Text = reader["Text"].ToString()
            };
            return comment;
        }
    }

    [Serializable]
    public class CommentView
    {
        public string Username { get; set; }
        public string Text { get; set; }

    }
}
