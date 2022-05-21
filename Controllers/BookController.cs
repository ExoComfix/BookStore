using Microsoft.AspNetCore.Mvc;


namespace BookStore.Controllers{

[ApiController]
[Route("[controller]s")]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
        new Book{
            Id = 1,
            Title = "My life begins in war",
            GenreId = 1, // Action
            PageCount = 200,
            PublishDate = new DateTime(2001,5,12)
            },
        new Book{
            Id = 2,
            Title = "Warcraft",
            GenreId = 2, // Fantastic
            PageCount = 350,
            PublishDate = new DateTime(2000,3,5)
            },
        new Book{
            Id = 3,
            Title = "Witcher",
            GenreId = 2, // Fantastic
            PageCount = 150,
            PublishDate = new DateTime(2010,5,9)
            }
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }
        [HttpGet("{id}")]
        public Book GetbyId(int id)
        {
            var book = BookList.Where(book => book.Id == id).SingleOrDefault();
            return book;
        }
    }
}