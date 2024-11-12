using Common.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class PlaceHolderImage
    {
        public static Image GetPlaceHolderImage() {

            string currentDir = Environment.CurrentDirectory;
            string localPath = "\\Common\\Helpers\\placeholder.png";
            DirectoryInfo directory = new DirectoryInfo(
                Path.GetFullPath(Path.Combine(currentDir, @"..\..\..\" + localPath)));
           

            Image image = new Image()
            {
                Id = Guid.NewGuid(),
                Path = directory.ToString(),
                CreatedOn = DateTime.Now
            };
            return image;
        }
    }
}
