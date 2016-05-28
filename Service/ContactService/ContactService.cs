using System;
using System.Linq;
using DataAccess;
using Repository.ContactRepository;

namespace Service.ContactService
{
    public class ContactService : IContactService
    {
        private readonly IContactRepostory contactRepostory;
        public ContactService()
        {
            contactRepostory = new ContactRepostory();
        }
        public void Create(Contact contact)
        {
            contactRepostory.Create(contact);
        }

        public void Delete(int id)
        {
            contactRepostory.Delete(id);
        }

        public IQueryable<Contact> GetAll()
        {
            return contactRepostory.GetAll();
        }

        public Contact GetById(int id)
        {
            return contactRepostory.GetById(id);
        }

        public bool IsDuplicate(Contact contact)
        {
            return contactRepostory.IsDuplicate(contact);
        }

        public void Update(Contact contact)
        {
            contactRepostory.Update(contact);
        }
    }
}
