using System.Linq;
using BookStore.Infrastructure;
using BookStore.Infrastructure.Command;
using BookStore.Saxo.ProductService;
using BookStore.Search.CommandStack;
using BookStore.Search.QueryStack;

namespace BookStore.WebSite.Areas.CustomerSite.Commands
{
    public class UpdateCommandHandler : ICommandHandler
    {
        private readonly IProductApi _productApi;
        private readonly IQueryRepository _queryRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateCommandHandler(IProductApi productApi, IQueryRepository queryRepository, IUnitOfWork unitOfWork)
        {
            _productApi = productApi;
            _queryRepository = queryRepository;
            _unitOfWork = unitOfWork;
        }

        public void Handle(ICommand T)
        {
            UpdateCommand command = T as UpdateCommand;
            if (command == null) return;

            var notFound = command.Isbns.Except(_queryRepository.Get(command.Isbns).Select(x => x.Isbn13).ToArray()).ToArray();
            var result = _productApi.Get(notFound);
            if (result == null) return;

            foreach (var product in result)
            {
                _unitOfWork.Add(new BookStore.Search.CommandStack.Model.Book()
                {
                    Imageurl = product.imageurl,
                    Isbn13 = product.isbn13,
                    Title = product.title,
                    Url = product.url
                });
            }
            _unitOfWork.Save();
        }
    }
}
