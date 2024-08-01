using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class GetAllAdvertisementsSO : SystemOperationBase
    {
        public List<Advertisement> Result { get; set; }

        public GetAllAdvertisementsSO()
        {
        }

        protected override void ExecuteConcreteOperation()
        {

            Result = broker.GetAllAdvertisements();
        }
    }
}
