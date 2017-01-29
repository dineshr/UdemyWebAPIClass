using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UdemyWebAPIClass.Models;

namespace UdemyWebAPIClass.Controllers
{
    public class ContactsController : ApiController
    {
        Contacts[] contacts = new Contacts[]
        {
            new Contacts() {Id=0,FirstName="Peter",LastName="Smith" },
            new Contacts() {Id=0,FirstName="Bruce",LastName="Parker" },
            new Contacts() {Id=0,FirstName="Wayne",LastName="Jones" },
            new Contacts() {Id=0,FirstName="Jake",LastName="Banner" },
        };
        // GET: api/Contacts
        public IEnumerable<Contacts> Get()
        {
            return contacts;
        }

        // GET: api/Contacts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Contacts
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Contacts/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Contacts/5
        public void Delete(int id)
        {
        }
    }
}
