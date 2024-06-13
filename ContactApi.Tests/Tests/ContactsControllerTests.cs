using ContactsManagementApplication.Controllers;
using ContactsManagementApplication.Models;
using ContactsManagementApplication.Services.ContactService;
using Microsoft.AspNetCore.Mvc;
using Moq;
namespace ContactApi.Tests.Tests
{
    public class ContactsControllerTests
    {
        [Fact]
        public async Task GetAllContacts_ShouldReturnAllContacts()
        {
            // Arrange
            var mockService = new Mock<IContactService>();
            mockService.Setup(repo => repo.GetAllContactsAsync())
                .ReturnsAsync(new List<Contact>
                {
                    new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                    new Contact { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", PhoneNumber = "9876543210" }
                });
            var controller = new ContactsController(mockService.Object);

            // Act
            var result = await controller.GetContacts();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var contacts = Assert.IsAssignableFrom<IEnumerable<Contact>>(okResult.Value);
            Assert.Equal(2, contacts.Count());
        }

        [Fact]
        public async Task GetContactById_ShouldReturnContactWithGivenId()
        {
            // Arrange
            var mockService = new Mock<IContactService>();
            mockService.Setup(repo => repo.GetContactByIdAsync(1))
                .ReturnsAsync(new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" });
            var controller = new ContactsController(mockService.Object);

            // Act
            var result = await controller.GetContact(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var contact = Assert.IsType<Contact>(okResult.Value);
            Assert.Equal(1, contact.Id);
        }

        // Add more test cases for other controller actions
    }
}
