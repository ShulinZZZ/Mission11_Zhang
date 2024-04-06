
namespace Mission11_Zhang.Models
{
    public class EFBookRepository: IBookRepository
    {
        private readonly BooksDbContext _dbContext;
        public EFBookRepository(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Book> Books => _dbContext.Books;
    }
}
