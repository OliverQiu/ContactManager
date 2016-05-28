using DataAccess;
using System.Linq;

namespace Service.ContactService
{
    public interface IContactService
    {
        void Create(Contact contact);
        void Delete(int id);
        void Update(Contact contact);
        IQueryable<Contact> GetAll();
        Contact GetById(int id);
        bool IsDuplicate(Contact contact);
    }
}
