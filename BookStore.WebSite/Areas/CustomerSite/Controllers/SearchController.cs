using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;

namespace BookStore.WebSite.Areas.CustomerSite.Controllers
{
    public class SearchController : Controller
    {
        public SearchWorkerService WorkerService { get; private set; }
        // GET: CustomerSite/Home
        public SearchController(SearchWorkerService searchWorkerService)
        {
            if (searchWorkerService == null)
                throw new ArgumentNullException("workerService");

            WorkerService = searchWorkerService;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBooksByISBNs(string isbns)
        {
            return Json(WorkerService.GetBooksViewModel(isbns));
        }
    }
}