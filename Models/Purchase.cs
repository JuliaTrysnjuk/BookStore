using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        // ім’я та прізвище покупця
        public string Person { get; set; }
        // адреса покупця
        public string Address { get; set; }
        // ID книги
        public int BookId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }

        // public virtual Book Book { get; set; }
    }
}