using CA2BookServer.Controllers;
using CA2BookServer.Data;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace BookServerTest
{
    public class BooksUnitTest
    {
        CA2BookServerContext _context;

        
        [Fact]
        public async Task GetBooks_ShouldRetrun200Status()
        {

            var bookserver = new Mock<CA2BookServerContext>();
            bookserver.Setup(_=> _.GetBooks()).ReturnsAsync()
            var sut = new BooksController(bookserver.Object);


            /// Act
            var result = (OkObjectResult)await sut.GetAllAsync();

            // /// Assert
            result.StatusCode.Should().Be(200);
        }
    }
}