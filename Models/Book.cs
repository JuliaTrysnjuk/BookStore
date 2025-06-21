using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        // ID книги
        public int Id { get; set; }
        // Назва книги
        public string Name { get; set; }
        // Автор книги
        public string Author { get; set; }
        // Ціна
        public int Price { get; set; }
    }
}