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
            broker.Login(user);
        }
    }
}
