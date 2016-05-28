using Service.ContactService;
using System.Linq;
using System.Web.Mvc;
using DataAccess;

namespace WebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService contactService;
        public ContactController()
        {
            contactService = new ContactService();
        }
        // GET: Contact
        public ActionResult Index()
        {
            return View(contactService.GetAll().ToList());
        }

        // GET: Contact/Details/5
        public ActionResult Details(int id)
        {
            return View(contactService.GetById(id));
        }

        // GET: Contact/Create
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (contactService.IsDuplicate(contact))
                    {
                        TempData["AlertMessage"] = "This item has already exists.";
                        return View();
                    }
                    contactService.Create(contact);
                    return RedirectToAction("Index");
                }
                return View(contact);

            }
            catch
            {
                return View(contact);
            }
        }

        // GET: Contact/Edit/5
        public ActionResult Edit(int id)
        {
            return View(contactService.GetById(id));
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            try
            {
                if (contactService.IsDuplicate(contact))
                {
                    TempData["AlertMessage"] = "This item has already exists.";
                    return View();

                }
                contactService.Update(contact);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(contact);
            }
        }

        // GET: Contact/Delete/5
        public ActionResult Delete(int id)
        {
            return View(contactService.GetById(id));
        }

        // POST: Contact/Delete/5
        [HttpPost]
        public ActionResult Delete(Contact contact)
        {
            try
            {
                // TODO: Add delete logic here
                contactService.Delete(contact.Id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(contact);
            }
        }
    }
}
