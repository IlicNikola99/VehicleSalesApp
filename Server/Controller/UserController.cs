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
    public class UserController
    {
        private Broker broker;

        private static UserController instance;
        public static UserController Instance
        {
            get
            {
                if(instance == null) instance = new UserController();
                return instance;
            }
        }
        private UserController() { broker = new Broker(); }

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

        internal void AddUser(User argument)
        {
            AddUserSO addUser = new AddUserSO(argument);
            addUser.ExecuteTemplate();
        }

        //internal List<City> GetAllCity()
        //{
        //    try
        //    {
        //        broker.OpenConnection();
        //        return broker.GetAllCity();
        //    }
        //    finally
        //    {
        //        broker.CloseConnection();

        //    }
        //}
    }
}
