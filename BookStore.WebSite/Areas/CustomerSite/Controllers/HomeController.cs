﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;

namespace BookStore.WebSite.Areas.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        public HomeWorkerService WorkerService { get; private set; }
        // GET: CustomerSite/Home
        public HomeController(HomeWorkerService homeWorkerService)
        {
            if(homeWorkerService == null)
                throw new ArgumentNullException("workerService");

            WorkerService = homeWorkerService;
        }
        public ActionResult Index()
        {
            var model = WorkerService.GetCategoryViewModel();

            return View(model);
        }

    }
}