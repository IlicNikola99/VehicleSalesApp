using Common.Domain;

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

           broker.Update(advertisement);
        }
    }
}
