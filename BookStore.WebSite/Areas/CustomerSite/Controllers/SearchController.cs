using System;
using System.Web.Mvc;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;

namespace BookStore.WebSite.Areas.CustomerSite.Controllers
{
    public class SearchController : Controller
    {
        public SearchWorkerService WorkerService { get; private set; }
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

        //{isbns :['9788741201122','9788702168044']}
        [System.Web.Mvc.HttpPost]
        public ActionResult GetBooksByIsbns(string[] isbns)
        {
            return Json(WorkerService.GetBooksViewModel(isbns),JsonRequestBehavior.AllowGet);
        }
    }
}