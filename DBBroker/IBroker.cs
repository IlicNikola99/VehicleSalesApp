using Common.Domain;
using System.Collections.Generic;

namespace DBBroker
{
    public interface IBroker
    {

        void Rollback();

        void Commit();

        void BeginTransaction();

        void CloseConnection();

        void OpenConnection();

        IEntity Add(IEntity obj);

        IEntity GetOne(IEntity obj);

        List<IEntity> GetAll(IEntity obj);

        List<IEntity> Search(IEntity obj);

        void Delete(IEntity obj);

        void Update(IEntity obj);
    }
}
