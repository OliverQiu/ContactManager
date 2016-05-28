using System.Linq;
using System.Data.Entity;
using DataAccess;

namespace Repository.ContactRepository
{
    public class ContactRepostory : IContactRepostory
    {
        public void Create(Contact contact)
        {
            using (var db = new TradeEntities())
            {
                db.Contact.Add(contact);
                db.Entry(contact).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new TradeEntities())
            {
                var item = db.Contact.Find(id);
                if (item==null)
                {
                    return;
                }
                db.Entry(item).State = EntityState.Deleted;
                db.SaveChanges();
            }

        }

        public IQueryable<Contact> GetAll()
        {
            var db = new TradeEntities();
            return db.Contact.OrderBy(x=>x.Name);
        }

        public Contact GetById(int id)
        {
            using (var db = new TradeEntities())
            {
                return db.Contact.Find(id);
            }
        }

        public bool IsDuplicate(Contact contact)
        {
            using (var db = new TradeEntities())
            {
                var item = db.Contact.Where(x=>x.Name == contact.Name).FirstOrDefault();
                if (item != null && item.Id != contact.Id)
                {
                    return true;
                }
                return false;
            }
        }

        public void Update(Contact contact)
        {
            using (var db = new TradeEntities())
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
