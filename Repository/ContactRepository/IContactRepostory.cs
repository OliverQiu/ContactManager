using DataAccess;
using System.Linq;

namespace Repository.ContactRepository
{
    public interface IContactRepostory
    {
        void Create (Contact contact);
        IQueryable<Contact> GetAll ();
        void Update (Contact contact);
        void Delete (int id);
        Contact GetById(int id);
        bool IsDuplicate(Contact contact);
    }
}
