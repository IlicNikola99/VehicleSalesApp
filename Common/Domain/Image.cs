using Common.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Common.Domain
{
    [Serializable]
    public class Image : BaseEntity, IEntity
    {
        public Image()
        {
            this.Id = Guid.Empty;
            this.CreatedOn = DateTime.Now;
        }
        public Image(Guid advertisementId, string imagePath)
        {
            this.Id = Guid.Empty;
            this.AdvertisementId = advertisementId;
            this.Path = imagePath;
            this.CreatedOn = DateTime.Now;
        }
        public string Path { get; set; }

        public Guid AdvertisementId { get; set; }

        public bool Thumbnail { get; set; } = false;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableName => "[Image]";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertValues => $"'{Id}','{Path}', '{AdvertisementId}', '{CreatedOn}', '{Thumbnail}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableAlias => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string OrderByClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SelectValues => "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string UpdateValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string WhereClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string JoinClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchValues => "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchWhereClause => $"advertisementId = '{this.AdvertisementId}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string DeleteWhereClause => $"advertisementId = '{this.AdvertisementId}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public IEntity ReadObjectRow(SqlDataReader reader)
        {
            Image image = new Image
            {
                Id = (Guid)reader["Id"],
                Path = (string)reader["Path"],
                AdvertisementId = (Guid)reader["AdvertisementId"],
                CreatedOn = (DateTime)reader["CreatedOn"],
                Thumbnail = bool.Parse((string)reader["Thumbnail"])
            };
            return image;   
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}
