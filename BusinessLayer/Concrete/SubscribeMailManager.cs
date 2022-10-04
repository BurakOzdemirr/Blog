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
    
   public class SubscribeMailManager:IMailService
    {
        IMailDal _maildal;

     //   Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();

        public SubscribeMailManager(IMailDal maildal)
        {
            _maildal = maildal;
        }

     //   public void BLAdd(SubscribeMail p)
     //   {
        //  if(p.Mail.Length<=10 || p.Mail.Length>=50)
          //  {
          //      return -1;
         //   }
       //      reposubscribemail.Insert(p);
     //   }

        public SubscribeMail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubscribeMail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubscribeMail t)
        {
            _maildal.Insert(t);
        }

        public void TDelete(SubscribeMail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubscribeMail t)
        {
            throw new NotImplementedException();
        }
    }
}
