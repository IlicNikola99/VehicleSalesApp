using Common.Domain;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class PlaceHolderImage
    {
        public static Image GetPlaceHolderImage() {

            Image image = new Image()
            {
                Id = Guid.NewGuid(),
                Path = "C:\\Users\\Nikola\\Documents\\Projektovanje softvera\\PS Projekat\\Server\\Resource\\Images\\placeholder.png",
                CreatedOn = DateTime.Now
            };
            return image;
        }
    }
}
