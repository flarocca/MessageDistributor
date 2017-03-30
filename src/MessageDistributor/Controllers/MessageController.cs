using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;
using MessageDistributor.Services;
using Microsoft.AspNetCore.Mvc;

namespace MessageDistributor.Controllers
{
    public class MessageParser
    {
        public int ProducerId { get; set; }
        public int ServiceId { get; set; }
        public int ActionId { get; set; }
        public dynamic Body { get; set; }
        //... Other staff

        public Message Parse()
        {
            return new Message(this.ProducerId, this.ServiceId, this.ActionId, this.Body);
        }
    }

    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        private readonly BroadcastingService _broadcastingService = new BroadcastingService();

        // PUT api/message/asdflkuh684asd8
        [HttpPut("{id}")]
        public bool Put(string tokenProducer, [FromBody]MessageParser message)
        {
            //Here we will broadcast the message to all consumers suscribed to this service/action
            //We might also want to check if this producer has been suscribed to this service/action

            //After validating data
            _broadcastingService.SendMessage(message.Parse());
            return true;
        }
    }
}
