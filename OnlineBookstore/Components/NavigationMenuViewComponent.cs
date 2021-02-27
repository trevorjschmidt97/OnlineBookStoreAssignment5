using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;

namespace OnlineBookstore.Components
{
    // This is the class that will store the menu on the left side
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }

        // Returns basically html, automatically called in the .cshtml files
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(b => b.Category)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
