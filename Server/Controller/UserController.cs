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
        private User loggedInUser;
        private static UserController instance;
        public static UserController Instance
        {
            get
            {
                if (instance == null) instance = new UserController();
                return instance;
            }
        }
        private UserController() { broker = new Broker(); }

        public User Login(User user)
        {
            LoginSO so = new LoginSO(user);
            so.ExecuteTemplate();
            this.loggedInUser = so.Result;
            return so.Result;

        }

        internal void AddUser(User argument)
        {
            AddUserSO addUser = new AddUserSO(argument);
            addUser.ExecuteTemplate();
        }

        public User GetLoggedInUser()
        {
            if (loggedInUser == null)
            {
                throw new Exception("No user is logged in!");
            }
            return loggedInUser;
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
