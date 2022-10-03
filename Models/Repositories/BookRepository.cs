namespace BookStore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        List<Book> books;

        public BookRepository()
        {
            books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title ="c# Programming",
                    Description ="No Description"
                },
                  new Book()
                {
                    Id = 2,
                    Title ="Angular Programming",
                    Description ="No Data"
                },

            };
        }

        public void Add(Book entity)
        {
            books.Add(entity);
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);
        }

        public Book Find(int id)
        {
          var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id,Book newBook)
        {
            var book= Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
        }
    }
}
