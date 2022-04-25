using CA2BookServer.Controllers;
using CA2BookServer.Data;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using Xunit;


/*namespace BookServerTest
{
    public class BooksUnitTest
    {
        BooksController _controller;
        IBookService _service;

        
        [Fact]
        public async Task GetBooks_ShouldRetrun200Status()
        {

            var bookserver = new Mock<CA2BookServerContext>();
            bookserver.Setup(_ => _.GetBooks()).ReturnsAsync(BookMockData.BookData());
            var sut = new BooksController(bookserver.Object);


            /// Act
            var result = (OkObjectResult)await sut.GetBooks();

            // /// Assert
            result.StatusCode.Should().Be(200);
        }
    }
}*/