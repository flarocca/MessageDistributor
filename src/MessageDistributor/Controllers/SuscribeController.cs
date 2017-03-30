using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;
using Microsoft.AspNetCore.Mvc;
using Action = MessageDistributor.Entities.Action;
using MessageDistributor.Repositories;

namespace MessageDistributor.Controllers
{
    public class SuscriptionParser
    {
        public int ServiceId { get; set; }
        public int SuscriberId { get; set; }
        public IEnumerable<int> Actions { get; set; }
        //... Other staff

        public Suscription Parse()
        {
            return new Suscription(this.SuscriberId, this.ServiceId, this.Actions);
        }
    }

    [Route("api/[controller]")]
    public class SuscribeController : Controller
    {
        private readonly IRepository<Suscriber> _suscribersRepo = new SuscriberRepository();
        private readonly IRepository<Service> _servicesRepo = new ServiceRepository();
        private readonly IRepository<Suscription> _suscriptionRepo = new SuscriptionRepository();

        // PUT api/suscribe/asdf54a6sdfa84sdf
        [HttpPut("{id}")]
        public bool Put(string tokenSuscriptor, [FromBody]SuscriptionParser newSubscriptionToService)
        {
            //Addionally we could add some middleware to validate tokens and get from them suscriptor id
            //I will register here a valid suscriptor to a valid service. Depending on the suscriptor type
            //We can determine if It will suscribe as a producer or as a consumer
            //We might want to control which message can be sent to each consumer depending on consumer's suscriptions, the same applies to producers.

            var suscriber = _suscribersRepo.Get(newSubscriptionToService.SuscriberId);
            if (suscriber == null)
                throw new ArgumentException("Suscribe does not exist");

            var service = _servicesRepo.Get(newSubscriptionToService.ServiceId);
            if (service == null)
                throw new ArgumentException("Service does not exist");

            //Check for actions too?

            _suscriptionRepo.Save(newSubscriptionToService.Parse());

            return true;
        }

        // DELETE api/suscribe/5
        [HttpDelete("{id}")]
        public void Delete(int suscriptionId) //We might want to use a GUID
        {
        }
    }
}
