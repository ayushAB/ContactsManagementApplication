using ContactsManagementApplication.Models;
using ContactsManagementApplication.Repository.ContactsRepository;

namespace ContactApi.Tests.Mocks
{
    public class MockContactRepository : IContactRepository
    {
        private readonly List<Contact> _contacts;

        public MockContactRepository()
        {
            _contacts = new List<Contact>
            {
                new Contact { Id = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                new Contact { Id = 2, FirstName = "Jane", LastName = "Doe", Email = "jane.doe@example.com", PhoneNumber = "9876543210" }
            };
        }

        public Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            return Task.FromResult<IEnumerable<Contact>>(_contacts);
        }

        public Task<Contact> GetContactByIdAsync(int id)
        {
            return Task.FromResult(_contacts.FirstOrDefault(c => c.Id == id));
        }

        public Task AddContactAsync(Contact contact)
        {
            _contacts.Add(contact);
            return Task.CompletedTask;
        }

        public Task UpdateContactAsync(Contact contact)
        {
            var existingContact = _contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.PhoneNumber = contact.PhoneNumber;
            }
            return Task.CompletedTask;
        }

        public Task DeleteContactAsync(int id)
        {
            var contactToRemove = _contacts.FirstOrDefault(c => c.Id == id);
            if (contactToRemove != null)
            {
                _contacts.Remove(contactToRemove);
            }
            return Task.CompletedTask;
        }
    }
}
