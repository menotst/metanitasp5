using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Util;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            var books = db.Books;
            ViewBag.Books = books;
            return View();
        }

        public ActionResult GetImage()
        {
            string path = "../../Content/Images/Warface_sample.jpg";
            return new ImageResult(path);
        }
        public ActionResult GetHtml()
        {
            return new HtmlResult("<h2>Привет Мир!</h2>");
        }
        public string Square()
        {
            int a = Int32.Parse(Request.Params["a"]);
            int h = Int32.Parse(Request.Params["h"]);
            double s = a * h / 2;
            return "<h2> Площадь треугольника с основанием " + a + " и высотой " + h + " равна " + s + "</h2>";
        }
        [HttpGet]
        public ActionResult GetBook()
        {
            return View();
        }
        [HttpPost]
        public string PostBook()
        {
            string title=Request.Form["title"];
            string author=Request.Form["author"];
            return title + " " + author;
        }

        public string GetId(int id)
        {
            return id.ToString();
        }
        [HttpGet]
        public ActionResult Buy(int Id)
        {
            ViewBag.BookId = Id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return "Спасибо " + purchase.Person +", за покупку";
        }        
    }
}