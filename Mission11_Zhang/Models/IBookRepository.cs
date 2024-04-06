namespace Mission11_Zhang.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get;  }
    }
}
