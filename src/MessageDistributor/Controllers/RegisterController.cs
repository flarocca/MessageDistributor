using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageDistributor.Entities;
using MessageDistributor.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MessageDistributor.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly IRepository<Suscriber> _repo = new SuscriberRepository();
        public class SuscriberParser
        {
            public string Type { get; set; }
            public string UniqueIdentifier { get; set; }
            public string UrlCallback { get; set; }
            //... Other staff

            public Suscriber Parse()
            {
                switch (this.Type)
                {
                    case "CONSUMER":
                        return new Consumer(0, UrlCallback);
                    case "PRODUCER":
                        return new Producer(0);
                    default:
                        throw new ArgumentException();
                }
            }
        }

        // POST api/register
        [HttpPost]
        public string Post([FromBody]SuscriberParser newSuscriber)
        {
            //Here we will register suscribers, we might want to control both sides of the comunication channel, producers as well as consumers.
            //All validations before saving it
            _repo.Save(newSuscriber.Parse());
            //...stuff...
            var token = "generate identifying token";
            //Ideally, this token will identify unequivocally the suscriber. Using JWT (JSON Web Token) we can also include information within the token
            //From now on each suscriber will send this token as id. JWT protocol allows us even to set expiration date.
            return token;
        }

        // DELETE api/register/5
        [HttpDelete("{id}")]
        public void Delete(int idSuscriber)
        {
            _repo.Delete(idSuscriber);
        }
    }
}
