using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.WebSite.Areas.CustomerSite.Models
{
    public class CategoryViewModel
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public int TotalItems { get; set; }
    }
}