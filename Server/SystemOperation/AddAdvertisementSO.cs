using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class AddAdvertisementSO : SystemOperationBase
    {
        private readonly Advertisement advertisement;
        public Advertisement Result { get; set; }

        public AddAdvertisementSO(Advertisement advertisement)
        {
            this.advertisement = advertisement;
        }

        protected override void ExecuteConcreteOperation()
        {

            Result = (Advertisement)broker.Add(advertisement);
        }
    }
}
