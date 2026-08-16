using AddressBookApp.Business;
using AddressBookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AddressBookApp.Api
{
    /// <summary>
    /// API controller for managing contacts operations.
    /// Provides endpoints to retrieve, create, and manage individual contacts.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactsService _service;

        public ContactsController(IContactsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contacts>> GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id")]
        public ActionResult<Contacts> GetById(int id)
        {
            var result = _service.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<Contacts> Add(Contacts contact)
        {
            var created = _service.Add(contact);
            return CreatedAtAction(nameof(GetById), new { id = created.ContactId }, created);
        }
    }
}