
using ContactsManagementApplication.Models;
using Newtonsoft.Json;

namespace ContactsManagementApplication.Repository.ContactsRepository
{
    public class ContactRepository : IContactRepository
    {
        private readonly string _filePath = "Data/contacts.json";

        public async Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            return await ReadFromFileAsync();
        }

        public async Task<Contact> GetContactByIdAsync(int id)
        {
            var contacts = await ReadFromFileAsync();
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public async Task AddContactAsync(Contact contact)
        {
            var contacts = await ReadFromFileAsync();
            contact.Id = contacts.Any() ? contacts.Max(c => c.Id) + 1 : 1;
            contacts.Add(contact);
            await WriteToFileAsync(contacts);
        }

        public async Task UpdateContactAsync(Contact contact)
        {
            var contacts = await ReadFromFileAsync();
            var existingContact = contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.PhoneNumber = contact.PhoneNumber;
                await WriteToFileAsync(contacts);
            }
        }

        public async Task DeleteContactAsync(int id)
        {
            var contacts = await ReadFromFileAsync();
            var contactToRemove = contacts.FirstOrDefault(c => c.Id == id);
            if (contactToRemove != null)
            {
                contacts.Remove(contactToRemove);
                await WriteToFileAsync(contacts);
            }
        }

        private async Task<List<Contact>> ReadFromFileAsync()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Contact>();
            }

            var jsonData = await File.ReadAllTextAsync(_filePath);
            return JsonConvert.DeserializeObject<List<Contact>>(jsonData);
        }

        private async Task WriteToFileAsync(List<Contact> contacts)
        {
            var jsonData = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            await File.WriteAllTextAsync(_filePath, jsonData);
        }
    }
}
