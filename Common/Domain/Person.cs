using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]

    public class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsMarried { get; set; }
        public DateTime Birthday { get; set; }
        public City City { get; set; }

        public string TableName => "Person";

        public string Values => $"'{FirstName}', '{LastName}', '{Birthday.ToString("yyyyMMdd HH:mm")}', {(IsMarried ? 1 : 0)}, {City.ZipCode}";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
