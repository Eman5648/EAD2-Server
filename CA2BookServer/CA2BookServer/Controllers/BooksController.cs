#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CA2BookServer.Data;
using CA2BookServer.Model;

namespace CA2BookServer.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly CA2BookServerContext _context;

        public BooksController(CA2BookServerContext context)
        {
            _context = context;
        }


        // GET: api/Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Books>>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        // GET: api/Books/5
        [HttpGet("{name}")]
        public IEnumerable<Books> GetBooks(string name)
        {
            var books = _context.Books.Where(b => b.BookName == name);

            if (books == null)
            {
                return null;
            }

            return books;
        }


        // PUT: api/Books/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("View/{name}")]
        public async Task<IActionResult> PutBooks(string name)
        {
            Books b = _context.Books.FirstOrDefault(bk => bk.BookName == name);
            if (b == null)
            {
                return BadRequest();
            }

            else
            {
                b.Read++;
                _context.SaveChanges();
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Books>> PostBooks(Books books)
        {
            _context.Books.Add(books);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBooks", new { id = books.BookID }, books);
        }

        // DELETE: api/Books/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooks(int id)
        {
            var books = await _context.Books.FindAsync(id);
            if (books == null)
            {
                return NotFound();
            }

            _context.Books.Remove(books);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BooksExists(int id)
        {
            return _context.Books.Any(e => e.BookID == id);
        }
    }
}
