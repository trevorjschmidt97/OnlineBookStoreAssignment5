using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineBookstore.Models;
using OnlineBookstore.Models.ViewModels;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookRepository _repository;

        public int PageSize = 5;

        // Repository is Set when this controller is called
        public HomeController(ILogger<HomeController> logger, IBookRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Index(int page = 1)
        {
            // Returns the repository of books, passed into the Index View
            return View(new BookListViewModel
            {
                Books = _repository.Books
                .OrderBy(p => p.BookId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
