using Common;
using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
        private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if(instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { broker = new Broker(); }

        public User Login(User user)
        {
            LoginSO so = new LoginSO(user);
            so.ExecuteTemplate();
            return so.Result;

        }

        internal void AddPerson(Person argument)
        {
            AddPersonSO addPerson = new AddPersonSO(argument);
            addPerson.ExecuteTemplate();
        }

        internal List<City> GetAllCity()
        {
            try
            {
                broker.OpenConnection();
                return broker.GetAllCity();
            }
            finally
            {
                broker.CloseConnection();

            }
        }
    }
}
