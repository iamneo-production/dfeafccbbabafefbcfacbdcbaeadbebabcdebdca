using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookDbContext _context;

        public BookController(BookDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Book> books = _context.Books.ToList();
            return View(books);
        }

        // public IActionResult Search(string title)
        // {
        //     List<Book> books = _context.Books
        //         .Where(book => book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
        //         .ToList();
        //     return View("Index", books);
        // }

        // public IActionResult TotalCount()
        // {
        //     int totalCount = _context.Books.Count();
        //     return Content($"Total number of books: {totalCount}");
        // }
    }
}
