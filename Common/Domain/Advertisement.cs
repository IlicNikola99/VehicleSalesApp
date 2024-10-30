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
        public int Year { get; set; }
        public int Mileage { get; set; }
        public FuelType FuelType { get; set; }
        public List<Image> Images { get; set; }
        public string TableName => "[Advertisement]";
        public string Values => $"'{Id}','{User.Id}', '{Vehicle.Id}','{Price}', '{AcceptsExchange}', '{Description}', '{Year}', '{Mileage}','{FuelType}', '{CreatedOn}'";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }

        public List<IEntity> GetAll(SqlDataReader reader)
        {
            List<IEntity> resultList = new List<IEntity>();
            try
            {
                while (reader.Read())
                {
                    Advertisement advertisement = new Advertisement()
                    {
                        Id = (Guid)reader["Id"],
                        AcceptsExchange = bool.Parse((string)reader["AcceptsExchange"]),
                        User = new User()
                        {
                            Id = (Guid)reader["UserId"]
                        },
                        Vehicle = new Vehicle()
                        {
                            Id = (Guid)reader["VehicleId"]
                        },
                        Price = Convert.ToDecimal(reader["Price"]),
                        Description = (string)reader["Description"],
                        Year = (int)reader["year"],
                        Mileage = (int)reader["mileage"],
                        FuelType = (FuelType)Enum.Parse(typeof(FuelType), (string)reader["fuelType"]),
                        CreatedOn = (DateTime)reader["CreatedOn"]
                    };
                    resultList.Add(advertisement);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(">>>>>>>" + e.Message);
                throw new Exception("There was an error while fetching all advertisements");
            }
            finally
            {
                reader.Close();
            }
            return resultList;
        }

        public IEntity GetOne(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
