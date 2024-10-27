using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class GetAllCommentSO : SystemOperationBase
    {

        public List<CommentView> Result { get; set; }
        public Advertisement Advertisement { get; set; }

        public GetAllCommentSO(Advertisement advertisement)
        {
            Advertisement = advertisement;
        }

        protected override void ExecuteConcreteOperation()
        {
            Result = broker.GetAllCommentsForAdvertisement(Advertisement.Id);
        }
    }
}
