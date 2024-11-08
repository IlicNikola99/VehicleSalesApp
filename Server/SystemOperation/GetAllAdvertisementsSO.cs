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
            List<IEntity> foundAdvertisements = broker.GetAll(new Advertisement());
            Result = foundAdvertisements.Select(entity =>
            {
                if (entity is Advertisement advertisement)
                {
                    advertisement.User = (User)broker.GetOne(new User() { Id = advertisement.User.Id});
                    advertisement.Vehicle = (Vehicle)broker.GetOne(new Vehicle() { Id = advertisement.Vehicle.Id });

                    // Fetch all Images and filter those that match the Advertisement Id
                    List<IEntity> foundImages = broker.Search(new Image() { AdvertisementId = advertisement.Id});
                    List<Image> images = foundImages
                        .OfType<Image>()
                        .Where(image => image.AdvertisementId == advertisement.Id)
                        .ToList();

                    advertisement.Images = images;
                    return advertisement;
                }
                return null;
            })
            .Where(ad => ad != null)
            .ToList();
        }
    }
}
