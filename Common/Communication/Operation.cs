using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public enum Operation
    {
        CreatePerson,
        Login,
        Register,
        CreateVehicle,
        CreateAdvertisement,
        DisconnectClient,
        UploadImages,
        RemoveImages,
        GetAllAdvertisements
    }
}
