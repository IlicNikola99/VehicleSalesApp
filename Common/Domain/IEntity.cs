using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public interface IEntity
    {
        string TableName { get; }
        string Values { get; }

        List<IEntity> GetAll(SqlDataReader reader);
        IEntity GetOne(SqlDataReader reader);
        void GenerateNewId();

    }
}
