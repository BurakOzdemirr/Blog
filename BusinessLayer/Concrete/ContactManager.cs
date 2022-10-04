using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class ContactManager:IContactService
    {
        IContactDal _contactDal;

        Repository<Contact> repocontact = new Repository<Contact>();

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

      //  public void BLContactAdd(Contact c)
     //   {
          //  if(c.Mail=="" || c.Message=="" || c.Name=="" || c.Subject=="" || c.SurName=="" || c.Mail.Length<=10|| c.Subject.Length<= 3)

         //   {
         //       return -1;
         //   }
        //     repocontact.Insert(c);
      //  }



        public Contact GetByID(int id)
        {
            return _contactDal.Find(x => x.ContactID == id);
        }

     //   public Contact GetContactDetails(int id)
     //   {
       //     return repocontact.Find(x => x.ContactID == id);
     //   }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
