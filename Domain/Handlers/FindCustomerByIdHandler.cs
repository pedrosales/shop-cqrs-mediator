using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShopCqrsMediator.Domain.Queries.Requests;
using ShopCqrsMediator.Domain.Queries.Responses;
using ShopCqrsMediator.Domain.Repositories;

namespace ShopCqrsMediator.Domain.Handlers
{
    public class FindCustomerByIdHandler : IRequestHandler<FindCustomerByIdRequest, FindCustomerByIdResponse>
    {
        ICustomerRepository _repository;

        public FindCustomerByIdHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public Task<FindCustomerByIdResponse> Handle(FindCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            // TODO: Lógia de leitura se houver

            // Retorna o resultado
            var result = _repository.GetCustomerById(request);
            return Task.FromResult(result);
        }
    }
}