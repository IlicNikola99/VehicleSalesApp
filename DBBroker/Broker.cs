using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;
        public Broker()
        {
            connection = new DbConnection();
        }

        public User Login(User user)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [user] where username = '{user.Username}' and password = '{user.Password}'";
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                if (reader.Read() && reader.HasRows)
                {
                    User foundUser = new User
                    {
                        Id = (Guid)reader["id"],
                        Username = (string)reader["username"],
                        Password = (string)reader["password"],
                        FirstName = (string)reader["firstname"],
                        LastName = (string)reader["lastname"],
                        Address = (string)reader["address"],
                        City = (string)reader["city"],
                        PhoneNumber = (string)reader["phonenumber"],
                        CreatedOn = (DateTime)reader["createdon"]
                    };
                    return foundUser;
                }
                else { throw new Exception("No user found with the given credentials!"); }
            }
            finally
            {
                reader.Close();
            }
        }

        public void Rollback()
        {
            connection.Rollback();
        }

        public void Commit()
        {
            connection.Commit();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }
        public IEntity Add(IEntity obj)
        {
            SqlCommand cmd = connection.CreateCommand();
            obj.GenerateNewId();
            cmd.CommandText = $"insert into {obj.TableName} values({obj.Values} )";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return obj;
        }
        public void AddUser(User user)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into user values (@id, @user, @pass, @fn, @ln, @add, @city, @ph, @cron)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", Guid.NewGuid());
            command.Parameters.AddWithValue("@user", user.Username);
            command.Parameters.AddWithValue("@pass", user.Password);
            command.Parameters.AddWithValue("@fn", user.FirstName);
            command.Parameters.AddWithValue("@ln", user.LastName);
            command.Parameters.AddWithValue("@add", user.Address);
            command.Parameters.AddWithValue("@city", user.City);
            command.Parameters.AddWithValue("@ph", user.PhoneNumber);
            command.Parameters.AddWithValue("@cron", DateTime.Now);

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public List<City> GetAllCity()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from city";
            List<City> list = new List<City>();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                City city = new City()
                {
                    Name = (string)reader["Name"],
                    ZipCode = (int)reader["ZipCode"]
                };
                list.Add(city);
            }
            reader.Close();
            return list;
        }

        public List<Advertisement> GetAllAdvertisements()
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from [Advertisement]";
            List<Advertisement> list = new List<Advertisement>();
            SqlDataReader reader = command.ExecuteReader();
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
                    CreatedOn = (DateTime)reader["CreatedOn"]
                };
                list.Add(advertisement);
            }
            reader.Close();
            return list;
        }

        public User GetUserById(Guid userId)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [User] where Id = '{userId}' ";
            SqlDataReader reader = command.ExecuteReader();
            try
            {

                if (reader.Read() && reader.HasRows)
                {
                    User foundUser = new User
                    {
                        Id = (Guid)reader["id"],
                        Username = (string)reader["username"],
                        Password = (string)reader["password"],
                        FirstName = (string)reader["firstname"],
                        LastName = (string)reader["lastname"],
                        Address = (string)reader["address"],
                        City = (string)reader["city"],
                        PhoneNumber = (string)reader["phonenumber"],
                        CreatedOn = (DateTime)reader["createdon"]
                    };
                    return foundUser;
                }
                else { throw new Exception("No user found with the given id!"); }
            }
            finally
            {
                reader.Close();
            }
        }

        public Vehicle GetVehicleById(Guid vehicleId)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [Vehicle] where Id = '{vehicleId}' ";
            SqlDataReader reader = command.ExecuteReader();
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
                        Year = (int)reader["year"],
                        Mileage = (int)reader["mileage"],
                        FuelType = (FuelType)Enum.Parse(typeof(FuelType), (string)reader["fuelType"]),
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

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {entity.TableName}";
            SqlDataReader reader = command.ExecuteReader();
            List<IEntity> list = entity.GetReaderList(reader);
            command.Dispose();
            return list;
        }

        public Advertisement AddAdvertisement(Advertisement advertisement)
        {
            advertisement.Id = Guid.NewGuid();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into {advertisement.TableName} values (@id, @userId, @vehicleId, @exchange, @price, @desc, @cron)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@id", advertisement.Id);
            command.Parameters.AddWithValue("@userId", advertisement.User.Id);
            command.Parameters.AddWithValue("@vehicleId", advertisement.Vehicle.Id);
            command.Parameters.AddWithValue("@exchange", advertisement.AcceptsExchange ? "true" : "false");
            command.Parameters.AddWithValue("@price", advertisement.Price);
            command.Parameters.AddWithValue("@desc", advertisement.Description);
            command.Parameters.AddWithValue("@cron", DateTime.Now);

            command.ExecuteNonQuery();
            command.Dispose();
            return advertisement;
        }

        public List<Image> getImagesForAdvertisement(Guid advertisementId)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select * from [Image] where AdvertisementId = '{advertisementId}' ";
            SqlDataReader reader = command.ExecuteReader();
            List<Image> images = new List<Image>();
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

                        images.Add(image);
                    }
                }
                else { throw new Exception("No images found for the given advertisementId!"); }
                return images;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}
