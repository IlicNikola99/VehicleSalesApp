using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;


namespace Common.Domain
{
    [Serializable]
    public class Vehicle : BaseEntity, IEntity
    {
        public Vehicle()
        {
            this.Id = Guid.Empty;
            this.CreatedOn = DateTime.Now;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public BodyType BodyType { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public string TableName => "[Vehicle]";

        public string Values => $"'{Id}','{Make}', '{Model}','{BodyType}', '{Year}', '{Mileage}', '{FuelType}', '{CreatedOn}'";

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
