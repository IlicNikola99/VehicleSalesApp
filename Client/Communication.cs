using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Client
{
    public class Communication
    {

        private static Communication _instance;
        public static Communication Instance { 
            get 
            {
                if( _instance == null ) _instance = new Communication();
                return _instance;
            } 
        }
        private Communication()
        {
            
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            Thread.Sleep(3000);
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }
        public void Disconnect()
        {
            Request req = new Request
            {
                Argument = null,
                Operation = Operation.DisconnectClient
            };
            sender.Send(req);

            socket.Shutdown(SocketShutdown.Both);
            socket = null;
            sender = null;
            receiver = null; 
        }

        internal Response Login(User user)
        {
            Request req = new Request
            {
                Argument = user,
                Operation = Operation.Login
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }
        internal Response Register(User user)
        {
            Request request = new Request
            {
                Argument = user,
                Operation = Operation.Register
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response CreatePerson(Person person)
        {
            Request request = new Request
            {
                Argument = person,
                Operation = Operation.CreatePerson
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal object GetAllCity()
        {
            Request request = new Request
            {
                Operation = Operation.GetAllCity
            };
            sender.Send(request);
            Response response = (Response)receiver.Receive();
            return response.Result;

        }
    }
}
