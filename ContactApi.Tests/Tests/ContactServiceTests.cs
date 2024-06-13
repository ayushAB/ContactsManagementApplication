using ContactApi.Tests.Mocks;
using ContactsManagementApplication.Services.ContactService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApi.Tests.Tests
{
    public class ContactServiceTests
    {
        [Fact]
        public async Task GetAllContactsAsync_ShouldReturnAllContacts()
        {
            // Arrange
            var mockRepository = new MockContactRepository();
            var service = new ContactService(mockRepository);

            // Act
            var contacts = await service.GetAllContactsAsync();

            // Assert
            Assert.NotNull(contacts);
            Assert.Equal(2, contacts.Count());
        }

        [Fact]
        public async Task GetContactByIdAsync_ShouldReturnContactWithGivenId()
        {
            // Arrange
            var mockRepository = new MockContactRepository();
            var service = new ContactService(mockRepository);
            int id = 1;

            // Act
            var contact = await service.GetContactByIdAsync(id);

            // Assert
            Assert.NotNull(contact);
            Assert.Equal(id, contact.Id);
        }

        // Add more test cases for Add, Update, and Delete operations
    }
}
