using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableName => "[Advertisement]";
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertValues => $"'{Id}','{User.Id}', '{Vehicle.Id}', '{AcceptsExchange}','{Price}', '{Description}', '{Year}', '{Mileage}','{FuelType}', '{CreatedOn}'";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TableAlias => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string InsertColumns => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SelectValues => "*";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string UpdateValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string WhereClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string JoinClause => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchValues => "";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string SearchWhereClause => "";

        public void GenerateNewId()
        {
            this.Id = Guid.NewGuid();
        }
        public IEntity ReadObjectRow(SqlDataReader reader)
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
            return advertisement;
        }

        public IEntity ReadObjectRowSearch(SqlDataReader reader)
        {
            return ReadObjectRow(reader);
        }
    }
}
