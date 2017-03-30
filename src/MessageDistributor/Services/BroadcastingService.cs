using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MessageDistributor.Entities;
using MessageDistributor.Repositories;

namespace MessageDistributor.Services
{
    public class BroadcastingService
    {
        private SuscriberRepository _suscriberRepo = new SuscriberRepository();
        public void SendMessage(Message message)
        {
            //look for all consumers suscribed to Message.ServiceId and Message.ActionID
            var consumersList = (IEnumerable<Consumer>) _suscriberRepo.GetConsumersByServiceAndAction(message.ServiceId, message.ActionId);
            var urlCallbacks = consumersList.Select(s => s.UrlCallback);
            foreach (var url in urlCallbacks)
            {
                //Let supouse that first we might want to save some data, and probably, we might want to save the response as well.
                Task.Run(() => { });
            }
        }
    }
}
