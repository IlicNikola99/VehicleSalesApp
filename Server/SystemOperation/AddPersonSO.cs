using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class AddPersonSO : SystemOperationBase
    {
        private readonly Person p;

        public AddPersonSO(Person p)
        {
            this.p = p;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(p);
        }
    }
}
