using Common.Helpers;
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

        public bool Thumbnail { get; set; } = false;

        public string TableName => "[Image]";

        public string Values => $"'{Id}','{Path}', '{AdvertisementId}', '{CreatedOn}', '{Thumbnail}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public List<IEntity> GetAll(SqlDataReader reader)
        {
            List<IEntity> resultList = new List<IEntity>();
            try
            {

                if (reader.Read() && reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Image image = new Image
                        {
                            Id = (Guid)reader["Id"],
                            Path = (string)reader["Path"],
                            AdvertisementId = (Guid)reader["AdvertisementId"],
                            CreatedOn = (DateTime)reader["CreatedOn"]
                        };

                        resultList.Add(image);
                    }
                }
                else
                {

                    resultList.Add(PlaceHolderImage.GetPlaceHolderImage());
                }
                return resultList;
            }
            finally
            {
                reader.Close();
            }
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
