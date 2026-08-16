using AddressBookApp.Business;
using AddressBookApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AddressBookApp.Api
{
    /// <summary>
    /// API controller for managing address books operations.
    /// Provides endpoints to retrieve, create, and manage address books and their related contacts.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookService _service;

        public AddressBookController(IAddressBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AddressBook>> GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet("{id")]
        public ActionResult<AddressBook> GetById(int id)
        {
            var result = _service.GetById(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public ActionResult<AddressBook> Add(AddressBook addressBook)
        {
            var created = _service.Add(addressBook);
            return CreatedAtAction(nameof(GetById), new { id = created.AddressBookId }, created);
        }
    }
}