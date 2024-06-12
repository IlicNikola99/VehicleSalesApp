using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class AddVehicleSO : SystemOperationBase
    {
        private readonly Vehicle v;

        public AddVehicleSO(Vehicle v)
        {
            this.v = v;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(v);
        }
    }
}
