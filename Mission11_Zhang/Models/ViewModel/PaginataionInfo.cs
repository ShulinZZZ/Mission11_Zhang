namespace Mission11_Zhang.Models.ViewModel
{
	public class PaginataionInfo
	{
		public int TotalItems { get; set; }
		public int ItemsPerPages { get; set; }
		public int CurrentPage { get; set; }
		public int TotalPages => (int) (Math.Ceiling((decimal) TotalItems / ItemsPerPages));
	}
}
