using Microsoft.AspNetCore.Mvc;
using Mission11_Zhang.Models;
using Mission11_Zhang.Models.ViewModel;
using System.Diagnostics;

namespace Mission11_Zhang.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index(int pageNum)
		{
            int pageSize = 10;

			var bookList = _bookRepository.Books
				.OrderBy(book => book.BookID) // Make sure to order by some property
				.Skip((pageNum - 1) * pageSize)
				.Take(pageSize);

			//var bookList = new BookstoreListViewModel
			//{
			//    Books = _bookRepository.Books
			//        .Skip((pageNum - 1) * pageSize)
			//        .Take(pageSize),

			//    paginataionInfo = new PaginataionInfo
			//    {
			//        CurrentPage = pageNum,
			//        ItemsPerPages = pageSize,
			//        TotalItems = _bookRepository.Books.Count()
			//    }
			//}
			;
            return View(bookList);
        }

    }
}
