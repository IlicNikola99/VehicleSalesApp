using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class AddUserSO : SystemOperationBase
    {
        private readonly User u;

        public AddUserSO(User u)
        {
            this.u = u;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(u);
        }
    }
}
