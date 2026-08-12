using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace ContactApp.Tests
{
    [TestFixture]
    public class ContactsApiTests
    {
        private WebApplicationFactory<Program> _factory = null!;
        private HttpClient _client = null!;

        [OneTimeSetUp]
        public void SetUp()
        {
            _factory = new WebApplicationFactory<Program>();
            _client = _factory.CreateClient();
        }
        [OneTimeTearDown]
        public void TearDown()
        {
            _client.Dispose();
            _factory.Dispose();
        }
        [Test]
        public async Task GetAllContacts_ShouldReturnSuccessCode()
        {
            var response = await _client.GetAsync("/api/Contacts");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public async Task CreateContact_ShouldReturnCreatedCode()
        {
            var newContact = new
            {
                ContactName = "Amritanshu",
                ContactEmail = "amritanshu.gupta@gmail.com",
                ContactNumber = "1234567890"
            };
            var response = await _client.PostAsJsonAsync("/api/Contacts",newContact);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        public async Task DeletingNonExistingContact_ShouldReturnNotFound()
        {
            var response = await _client.DeleteAsync("/api/Contacts/9999");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound));
        }
    }
}