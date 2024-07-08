using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class UploadImagesSO : SystemOperationBase
    {

        private readonly List<Image> images;

        public UploadImagesSO(List<Image> images)
        {
            this.images = images;
        }
        protected override void ExecuteConcreteOperation()
        {
            foreach (var img in images)
            {
                broker.Add(img);
            }
        }
    }
}
