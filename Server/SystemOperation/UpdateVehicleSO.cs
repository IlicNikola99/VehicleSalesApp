using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class UpdateVehicleSO : SystemOperationBase
    {
        public Vehicle v;

        public UpdateVehicleSO(Vehicle v)
        {
            this.v = v;
        }
        protected override void ExecuteConcreteOperation()
        {
            this.v = broker.UpdateVehicle(v);
        }
    }
}
