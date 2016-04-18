using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using BookStore.Search.CommandStack.Sagas;
using BookStore.Search.QueryStack;
using BookStore.Search.QueryStack.Model;
using BookStore.WebSite.Areas.CustomerSite.Controllers;
using BookStore.WebSite.Areas.CustomerSite.Models;
using BookStore.WebSite.Areas.CustomerSite.WorkerServices;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BookStore.WebSite.Test
{
    [TestClass]
    public class WhenITestSearchController 
    {
        [TestMethod]
        public void GetBooksByIsbnsWorksCorrectly()
        {
            var mock = new Mock<IQueryRepository>();
            var mockUpdate = new Mock<IUpdateCommandHandler>();
            mock.Setup(x => x.Get(It.IsAny<string[]>()))
                .Returns((new [] {new Book() { Imageurl = "1", Title = "2", Url = "3"} }).AsQueryable());
            var searchController = new SearchController(new SearchWorkerService(mock.Object,mockUpdate.Object));
            var result =searchController.GetBooksByIsbns(new []{ "9788741201122" }) as JsonResult;

            var books = (result.Data as IEnumerable<BookViewModel>).ToList();
            books.Count().Should().Be(1);
            books.First().Imageurl.Should().Be("1");


        }
    }
}
