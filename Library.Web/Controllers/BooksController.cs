﻿using System.Collections.Generic;
using Library.Entities;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Library.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/Books")]
    public class BooksController : Controller
    {
        private IConfiguration _connectionString;
        private BookService _bookService;
        public BooksController(IConfiguration connectionString)
        {
            _connectionString = connectionString;
            _bookService = new BookService(_connectionString.GetConnectionString("LibraryDatabase"));
        }

       // [HttpGet]
       [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _bookService.GetAll();
        }
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _bookService.Get(id);
        }
        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            _bookService.Create(book);
            return Json(1);
        }

        [HttpPut]
        public IActionResult UpdateBook([FromBody]Book book)
        {
            _bookService.Update(book);
            return Json(1);
        }
    }
}