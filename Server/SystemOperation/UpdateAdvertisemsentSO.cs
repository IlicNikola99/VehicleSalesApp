using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class UpdateAdvertisemsentSO : SystemOperationBase
    {
        private readonly Advertisement advertisement;
        public Advertisement Result { get; set; }

        public UpdateAdvertisemsentSO(Advertisement advertisement)
        {
            this.advertisement = advertisement;
        }

        protected override void ExecuteConcreteOperation()
        {

            Result = broker.UpdateAdvertisement(advertisement);
        }
    }
}
