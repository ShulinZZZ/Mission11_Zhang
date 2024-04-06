namespace Mission11_Zhang.Models.ViewModel
{
	public class BookstoreListViewModel
	{
		public IQueryable<Book>? Books { get; set;}
		public PaginataionInfo paginataionInfo { get; set;} = new PaginataionInfo();
	}
}
