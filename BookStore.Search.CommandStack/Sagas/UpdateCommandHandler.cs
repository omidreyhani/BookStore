using System.Data.Entity;
using System.Linq;
using BookStore.Saxo.ProductService;
using BookStore.Search.CommandStack.Commands;

namespace BookStore.Search.CommandStack.Sagas
{
    public class UpdateCommandHandler  : IUpdateCommandHandler
    {
        private readonly IProductApi _productApi;
        private readonly IUnitOfWork _unitOfWork;


        public UpdateCommandHandler(IProductApi productApi, IUnitOfWork unitOfWork)
        {
            _productApi = productApi;
            _unitOfWork = unitOfWork;
        }

        public void Execute(ICommand T)
        {
            UpdateCommand command = T as UpdateCommand;
            if (command == null) return;
            var isbns = command.Isbns;
            for (int i = 0; i < isbns.Length/10; i++)
            {
                var chunk = isbns.Skip(i*10).Take(10).ToArray();


                var founded = _unitOfWork.Repository.GetBooks().AsNoTracking().Where(x => isbns.Contains(x.Isbn13)).Select(x => x.Isbn13);
                var notFound = chunk.Except(founded).ToArray();
                var result = _productApi.Get(notFound);
                if (!result.Any()) continue;

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

    public interface IUpdateCommandHandler
    {
        void Execute(ICommand T);
    }
}
