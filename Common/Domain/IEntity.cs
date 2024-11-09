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
        string TableAlias { get; }
        string InsertValues { get; }
        string SelectValues { get; }
        string UpdateValues { get; }
        string SearchValues { get; }

        string WhereClause { get; }
        string JoinClause { get; }
        string SearchWhereClause { get; }
        string OrderByClause { get; }
        void GenerateNewId();
        IEntity ReadObjectRow(SqlDataReader reader);
        IEntity ReadObjectRowSearch(SqlDataReader reader);

    }
}
