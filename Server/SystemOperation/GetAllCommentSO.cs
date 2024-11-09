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
            List<IEntity> foundComments = broker.Search(new Comment() { AdvertisementId = Advertisement.Id });
            List<CommentView> commentViews = new List<CommentView>();


            foundComments.ForEach(comment =>
            {
                if (comment is Comment c)
                {
                    CommentView commentView = new CommentView() { Username = c.Username, Text = c.Text };
                    commentViews.Add(commentView);
                }

            });

            Result = commentViews;
        }
    }
}
