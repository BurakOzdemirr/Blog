using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurakBlog.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        Context _context = new Context();
        public ActionResult Index()
        {
            var totalCategory = _context.Categories.Count(); // Toplam Kategori
            ViewBag.totalNumberOfCategories = totalCategory;


            var totalBlog = _context.Blogs.Count(); // Toplam Blog
            ViewBag.totalNumberOfBlogs = totalBlog;

            var totalAuthor = _context.Authors.Count(); // Toplam Yazarlar
            ViewBag.totalNumberOfAuthors = totalAuthor;

            var totalComment = _context.Comments.Count(); // Toplam Yazarlar
            ViewBag.totalNumberOfComments = totalComment;

            var mostTitles = _context.Categories.Max(x => x.CategoryName);
            ViewBag.categoryNameWithTheMostTitles = mostTitles;

            var difference = _context.Categories.Count(m => m.CategoryStatus == true) - _context.Categories.Count(m => m.CategoryStatus == false);
            ViewBag.StatusDifferent = difference;

            string session = (string)Session["UserName"];
            ViewBag.a = session;
            return View();
        }


        //public PartialViewResult LayoutStatistics()
        //{
        //    var totalCategory = _context.Categories.Count(); // Toplam Kategori
        //    ViewBag.totalCategory1 = totalCategory;

        //    var totalBlog = _context.Blogs.Count(); // Toplam Blog
        //    ViewBag.totalBlogs2 = totalBlog;

        //    var totalAuthor = _context.Authors.Count(); // Toplam Yazarlar
        //    ViewBag.totalAuthors3 = totalAuthor;

        //    var totalComment = _context.Comments.Count(); // Toplam Yazarlar
        //    ViewBag.totalComments4 = totalComment;

        //    string session = (string)Session["AdminMail"];
        //    ViewBag.a = session;
        //    return PartialView();
        //}
    }
}