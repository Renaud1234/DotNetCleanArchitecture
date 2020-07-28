using CleanArchitectureDemo.Application.Interfaces;
using CleanArchitectureDemo.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.UI.MVC.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetBooks();
            return View(model);
        }
    }
}
