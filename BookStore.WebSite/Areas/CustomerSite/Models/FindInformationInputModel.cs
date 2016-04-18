using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.WebSite.Areas.CustomerSite.Models
{
    public class FindInformationInputModel
    {
        [MinLength(1)]
        public string[] Isbns { get; set; }
    }
}