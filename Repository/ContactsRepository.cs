using System.Collections.Generic;
using System.Linq;
using StartProject.Contexts;
using StartProject.Models;
 
namespace StartProject.Repository
{
    public class ContactsRepository : IContactsRepository
    {
        static List<Contacts> ContactsList = new List<Contacts>();
        ContactsContext _context;
        
        public ContactsRepository(ContactsContext context){
            _context = context;
        }

        public void Add(Contacts item)
        {
            
            _context.Add(item);
            _context.SaveChanges();
            //ContactsList.Add(item);
        }
 
        public Contacts Find(string key)
        {
            return _context.Contacts.Where(x => x.MobilePhone.Equals(key)).FirstOrDefault();
            /*return ContactsList
                .Where(e => e.MobilePhone.Equals(key))
                .SingleOrDefault();*/
        }
 
        public IEnumerable<Contacts> GetAll()
        {
            return _context.Contacts;
            //return ContactsList;
        }
 
        public void Remove(string Id)
        {
            var itemToRemove = Find(Id);
            _context.Remove(itemToRemove);
            _context.SaveChanges();
            /*
            if (itemToRemove != null)
                ContactsList.Remove(itemToRemove);*/            
        }
 
        public void Update(Contacts item)
        {
            var itemToUpdate = Find(item.MobilePhone); //ContactsList.SingleOrDefault(r => r.MobilePhone == item.MobilePhone);
            if (itemToUpdate != null)
            {
                itemToUpdate.FirstName = item.FirstName;
                itemToUpdate.LastName = item.LastName;
                itemToUpdate.IsFamilyMember = item.IsFamilyMember;
                itemToUpdate.Company = item.Company;
                itemToUpdate.JobTitle = item.JobTitle;
                itemToUpdate.Email = item.Email;
                itemToUpdate.MobilePhone = item.MobilePhone;
                itemToUpdate.DateOfBirth = item.DateOfBirth;
                itemToUpdate.AnniversaryDate = item.AnniversaryDate;
            }
            _context.SaveChanges();
        }
    }
}