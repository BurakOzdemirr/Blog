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
   public class AboutManager: IAboutService
    {
        IAboutDal _aboutDal;

        Repository<Admin> repoadmin = new Repository<Admin>();
        Repository<About> repoabout = new Repository<About>();

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

   //     public void UpdateAboutBM(About p)
    //    {
        //    About about = repoabout.Find(x => x.AboutID == p.AboutID);
        //    about.AboutContent = p.AboutContent;
        //    about.AboutContent2 = p.AboutContent2;
        //    about.AboutImage1 = p.AboutImage1;
        //    about.AboutImage2 = p.AboutImage2;
         //   about.AboutID = p.AboutID;
        //     repoabout.Update(about);
     //   }

        public List<Admin> GetAdminByUserName(string p)
        {
            return repoadmin.List(x => x.UserName == p);
        }

        public List<About> GetList()
        {
            return _aboutDal.List();
        }

      //  public void AboutAdd(About about)
      //  {
        //    throw new NotImplementedException();
       // }

        public About GetByID(int id)
        {
            throw new NotImplementedException();
        }

     //   public void AboutDelete(About about)
    //    {
       //     throw new NotImplementedException();
    //    }

     //   public void AboutUpdate(About about)
     //   {
     //       _aboutDal.Update(about);
     //   }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
