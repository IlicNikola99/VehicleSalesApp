using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        private readonly User user;
        public User Result { get; set; }

        public LoginSO(User user)
        {
            this.user = user;
        }

        protected override void ExecuteConcreteOperation()
        {

            List<User> users = broker.GetAll(new User()).OfType<User>().ToList();
            Result = null;

            foreach (User u in users)
            {
                if (u.Username.Equals(user.Username) && u.Password.Equals(user.Password))
                {
                    Result = u;
                }
            }
        }
    }
}
