using BookApi.Models;
using BookApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;

        }

        [HttpGet]

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        [HttpGet("{id}")]
        public  async Task<ActionResult<Book>> GetBooks(int id)
        {
            return await _bookRepository.Get(id);

        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBooks([FromBody] Book book)
        {
            var newBook = await _bookRepository.Create(book);
            return CreatedAtAction(nameof(GetBooks), new { id = newBook.Id }, newBook);

        }

        [HttpPut]
        public async Task<ActionResult> PostBooks(int id,[FromBody] Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }
            await _bookRepository.Update(book);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var bookTodelete = await _bookRepository.Get(id);
            if (bookTodelete == null)
                return NotFound();
            await _bookRepository.Delete(bookTodelete.Id);
            return NoContent();


        }
    }
}
