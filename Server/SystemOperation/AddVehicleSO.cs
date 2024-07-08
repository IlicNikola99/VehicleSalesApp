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
        public Vehicle v;

        public AddVehicleSO(Vehicle v)
        {
            this.v = v;
        }
        protected override void ExecuteConcreteOperation()
        {
            this.v = (Vehicle)broker.Add(v);
        }
    }
}
