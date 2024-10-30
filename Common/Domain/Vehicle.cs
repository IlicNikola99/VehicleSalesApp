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
        public string TableName => "[Vehicle]";

        public string Values => $"'{Id}','{Make}', '{Model}','{BodyType}','{CreatedOn}'";

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
            try
            {

                if (reader.Read() && reader.HasRows)
                {
                    Vehicle foundVehicle = new Vehicle
                    {
                        Id = (Guid)reader["id"],
                        Make = (string)reader["make"],
                        Model = (string)reader["model"],
                        BodyType = (BodyType)Enum.Parse(typeof(BodyType), (string)reader["bodyType"]),
                        CreatedOn = (DateTime)reader["CreatedOn"]
                    };
                    return foundVehicle;
                }
                else { throw new Exception("No vehicle found with the given id!"); }
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
