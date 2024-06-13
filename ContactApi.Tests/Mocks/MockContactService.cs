using ContactsManagementApplication.Models;
using ContactsManagementApplication.Repository.ContactsRepository;
using ContactsManagementApplication.Services.ContactService;

namespace ContactApi.Tests.Mocks
{
    public class MockContactService : IContactService
    {
        private readonly IContactRepository _repository;

        public MockContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            return _repository.GetAllContactsAsync();
        }

        public Task<Contact> GetContactByIdAsync(int id)
        {
            return _repository.GetContactByIdAsync(id);
        }

        public Task AddContactAsync(Contact contact)
        {
            return _repository.AddContactAsync(contact);
        }

        public Task UpdateContactAsync(Contact contact)
        {
            return _repository.UpdateContactAsync(contact);
        }

        public Task DeleteContactAsync(int id)
        {
            return _repository.DeleteContactAsync(id);
        }
    }
}
