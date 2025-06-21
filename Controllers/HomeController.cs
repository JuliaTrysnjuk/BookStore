using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        // Створюємо контекст даних
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            // Отримуємо з бази даних всі об’єкти Book
            IEnumerable<Book> books = db.Books;
            // передаємо всі отримані об’єкти в динамічну властивість Books в ViewBag
            ViewBag.Books = books;
            // повертаємо представлення
            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // Додаємо інформацію про купівлю в базу даних
            db.Purchases.Add(purchase);
            // Зберігаємо в базу даних всі зміни
            db.SaveChanges();
            return "Дякуємо," + purchase.Person + ", за покупку!";
        }
    }
}