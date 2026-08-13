using ContactsApp.Business;
using ContactsApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContactsApp.Api
{
    /// <summary>
    /// API controller that handles HTTP requests related to contacts.
    /// Provides endpoints for retrieving and creating contacts.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsAppController : ControllerBase
    {
        private readonly IContactServices _contactServices;

        public ContactsAppController(IContactServices contactServices)
        {
            _contactServices = contactServices;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ContactsModel>> GetAllContacts()
        {
            var contacts = _contactServices.GetAllContacts();
            return Ok(contacts);
        }

        [HttpGet("{contactId}")]
        public ActionResult<ContactsModel> GetContactById(int contactId)
        {
            var contact = _contactServices.GetContactById(contactId);
            if(contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }

        [HttpPost]
        public ActionResult<ContactsModel> AddNewContact(ContactsModel contact)
        {
            var createdContact = _contactServices.AddNewContact(contact);
            return CreatedAtAction(nameof(GetContactById), new { contactId = createdContact.ContactId },
                createdContact);
        }
    }
}