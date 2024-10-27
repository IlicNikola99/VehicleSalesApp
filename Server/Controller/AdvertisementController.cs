using Common.Domain;
using DBBroker;
using Server.SystemOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Controller
{
    public class AdvertisementController
    {
        private Broker broker;
        private static AdvertisementController instance;
        public static AdvertisementController Instance
        {
            get
            {
                if (instance == null) instance = new AdvertisementController();
                return instance;
            }
        }
        private AdvertisementController() { broker = new Broker(); }

        
       

        internal void AddAdvertisement(Advertisement argument)
        {
            AddAdvertisementSO addAdvertisement = new AddAdvertisementSO(argument);
            addAdvertisement.ExecuteTemplate();
        }

        internal List<Advertisement> GetAllAdvertisements()
        {
            GetAllAdvertisementsSO getAllAdvertisements = new GetAllAdvertisementsSO();
            getAllAdvertisements.ExecuteTemplate();
            return getAllAdvertisements.Result;
        }

        internal void UpdateAdvertisement(Advertisement argument)
        {
            UpdateAdvertisemsentSO updateAdvertisement = new UpdateAdvertisemsentSO(argument);
            updateAdvertisement.ExecuteTemplate();
        }

        internal Comment AddComment(Comment argument)
        {
            AddCommentSO addComment = new AddCommentSO(argument);
            addComment.ExecuteTemplate();
            return argument;
        }

        internal List<CommentView> GetAllComments(Advertisement argument)
        {
            GetAllCommentSO getAllComment = new GetAllCommentSO(argument);
            getAllComment.ExecuteTemplate();
            return getAllComment.Result;
        }
    }
}

