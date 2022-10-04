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
   public class AuthorManager:IAuthorService
    {
        IAuthorDal _authordal;
        Repository<Author> repoauthor = new Repository<Author>();

        public AuthorManager(IAuthorDal authordal)
        {
            _authordal = authordal;
        }

        // Tüm yazar listesini getirme
     

        //Yeni yazar ekleme işlemi
       // public void AddAuthorBL(Author p)
       // {
            //parametreden gönderilen değerlerin geçerliliğinin kontrolü
           // if(p.AuthorName=="" | p.AboutShort=="" | p.AuthorTitle =="")
            //{
           //     return -1;
            //}
          //   repoauthor.Insert(p);
       // }

        // Yazarı id değerine göre edit sayfasına taşıma
      //  public Author FindAuthor(int id)
      //  {
       //     return repoauthor.Find(x => x.AuthorID == id);
     //   }
     //   public void EditAuthor(Author p)
    //    {
       //     Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
       //     author.AboutShort = p.AboutShort;
         //   author.AuthorName = p.AuthorName;
           // author.AuthorImage = p.AuthorImage;
         //   author.AuthorAbout = p.AuthorAbout;
           // author.AuthorTitle = p.AuthorTitle;
   //         author.AuthorMail = p.AuthorMail;
     //       author.Password = p.Password;
       //     author.PhoneNumber = p.PhoneNumber;
         //    repoauthor.Update(author);
    //    }

        public List<Author> GetList()
        {
            return _authordal.List();
        }

      //  public void AuthorAdd(Author author)
      //  {
      //      _authordal.Insert(author);
      //  }

        public Author GetByID(int id)
        {
            return _authordal.GetByID(id);
        }

        public void AuthorDelete(Author author)
        {
            throw new NotImplementedException();
        }

       // public void AuthorUpdate(Author author)
      //  {
          //  _authordal.Update(author);
      //  }

        public void TAdd(Author t)
        {
            _authordal.Insert(t);
        }

        public void TDelete(Author t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            _authordal.Update(t);
        }
    }
}
