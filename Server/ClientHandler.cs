using Common.Communication;
using Common.Domain;
using Server.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        bool end;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
            end = false;
        }

        public void HandleRequest()
        {
            while (!end)
            {
                Request req = (Request)receiver.Receive();
                Response r = ProcessRequest(req);
                if (!end)
                {
                    sender.Send(r);
                }
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            try
            {
                switch (req.Operation)
                {           
                    case Operation.Register:
                        UserController.Instance.AddUser((User)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.Login:
                        r.Result = UserController.Instance.Login((User)req.Argument);
                        break;
                    case Operation.CreateVehicle:
                        VehicleController.Instance.AddVehicle((Vehicle)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.CreateAdvertisement:
                        AdvertisementController.Instance.AddAdvertisement((Advertisement)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.GetAllAdvertisements:
                        r.Result = AdvertisementController.Instance.GetAllAdvertisements();
                        break;
                    case Operation.UploadImages:
                        ImageController.Instance.UploadImages((List<Image>)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.RemoveImages:
                        ImageController.Instance.RemoveImages((Guid)req.Argument);
                        r.Result = req.Argument;
                        break;
                    case Operation.DisconnectClient:
                        end = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return r;
        }
    }
}
