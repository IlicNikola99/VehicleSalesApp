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
            var advertisements = broker.GetAllAdvertisements();
            Result = advertisements.Select(advertisement =>            {
                advertisement.User = broker.GetUserById(advertisement.User.Id);
                advertisement.Vehicle = broker.GetVehicleById(advertisement.Vehicle.Id);
                advertisement.Images = broker.getImagesForAdvertisement(advertisement.Id);
                return advertisement;
            }).ToList();
        }
    }
}
