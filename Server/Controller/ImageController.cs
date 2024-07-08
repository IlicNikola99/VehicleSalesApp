using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class ImageController
    {
        private Broker broker;
        private static ImageController instance;
        public static ImageController Instance
        {
            get
            {
                if (instance == null) instance = new ImageController();
                return instance;
            }
        }
        private ImageController() { broker = new Broker(); }

        internal void UploadImages(List<Image> images)
        {
            UploadImagesSO uploadImages = new UploadImagesSO(images);
            uploadImages.ExecuteTemplate(); 
        }
    }
}
