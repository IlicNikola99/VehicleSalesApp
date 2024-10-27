using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class AddCommentSO : SystemOperationBase
    {
        private readonly Comment c;

        public AddCommentSO(Comment c)
        {
            this.c = c;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Add(c);
        }
    }
}
