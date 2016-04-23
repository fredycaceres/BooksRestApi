using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksRestApi.Models;
using Microsoft.AspNet.Mvc;

namespace BooksRestApi.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private booksContext _context;

        public BooksController(booksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Books.ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([FromBody]Books book)
        {
            if (ModelState.IsValid)
            {
                _context.Books.Add(book);
                _context.SaveChanges();
                return this.CreatedAtRoute("GetBook", new { controller = "Books", id = book.id }, book);
            }

            return View(book);
        }

        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetById(int id)
        {
            var book = _context.Books.SingleOrDefault(m => m.id == id);
            if (book == null)
            {
                return this.HttpNotFound();
            }

            return this.Ok(book);
        }
    }
}
