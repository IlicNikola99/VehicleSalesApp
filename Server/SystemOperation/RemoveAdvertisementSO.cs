using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class RemoveAdvertisementSO : SystemOperationBase {
      
        private Advertisement advertisement;

        public RemoveAdvertisementSO(Advertisement advertisement)
        {
            this.advertisement = advertisement;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(advertisement);
        }
    }
}
