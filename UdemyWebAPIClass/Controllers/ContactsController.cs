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
            new Contacts() {Id=1,FirstName="Bruce",LastName="Parker" },
            new Contacts() {Id=2,FirstName="Wayne",LastName="Jones" },
            new Contacts() {Id=3,FirstName="Jake",LastName="Banner" },
        };
        // GET: api/Contacts
        public IEnumerable<Contacts> Get()
        {
            return contacts;
        }

        // GET: api/Contacts/5
        public IHttpActionResult Get(int id)
        {
            Contacts contact = contacts.FirstOrDefault<Contacts>(c => c.Id == id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        // POST: api/Contacts
        public IEnumerable<Contacts> Post([FromBody]Contacts newContact)
        {
            List<Contacts> contactList = contacts.ToList<Contacts>();
            newContact.Id = contactList.Count;
            contactList.Add(newContact);
            contacts = contactList.ToArray();

            return contacts;
        }

        // PUT: api/Contacts/5
        public IEnumerable<Contacts> Put(int id, [FromBody]Contacts updateContact)
        {
            Contacts contact = contacts.FirstOrDefault<Contacts>(c => c.Id == id);
            if(contact != null)
            {
                contact.FirstName = updateContact.FirstName;
                contact.LastName = updateContact.LastName;
            }

            return contacts;
        }

        // DELETE: api/Contacts/5
        public IEnumerable<Contacts> Delete(int id)
        {
            contacts = contacts.Where<Contacts>(c => c.Id != id).ToArray<Contacts>();
            return contacts;
        }
    }
}
