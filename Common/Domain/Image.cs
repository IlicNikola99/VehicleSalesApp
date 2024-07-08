using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        public string TableName => "[Image]";

        public string Values => $"'{Id}','{Path}', '{AdvertisementId}', '{CreatedOn}'";

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
