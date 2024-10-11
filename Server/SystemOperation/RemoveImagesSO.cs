using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    internal class RemoveImagesSO : SystemOperationBase
    {

        private Guid advertisementId;

        public RemoveImagesSO(Guid advertisementId)
        {
            this.advertisementId = advertisementId;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.RemoveImagesForAdvertisement(advertisementId);
        }
    }
}
