﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class AboutManager
    {
        Repository<Admin> repoadmin = new Repository<Admin>();
        Repository<About> repoabout = new Repository<About>();
        public List<About> GetAll()
        {
            return repoabout.List();
        }

        public int UpdateAboutBM(About p)
        {
            About about = repoabout.Find(x => x.AboutID == p.AboutID);
            about.AboutContent = p.AboutContent;
            about.AboutContent2 = p.AboutContent2;
            about.AboutImage1 = p.AboutImage1;
            about.AboutImage2 = p.AboutImage2;
            about.AboutID = p.AboutID;
            return repoabout.Update(about);
        }

        public List<Admin> GetAdminByUserName(string p)
        {
            return repoadmin.List(x => x.UserName == p);
        }
    }
}
