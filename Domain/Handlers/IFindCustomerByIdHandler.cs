using ShopCqrsMediator.Domain.Queries.Requests;
using ShopCqrsMediator.Domain.Queries.Responses;

namespace ShopCqrsMediator.Domain.Handlers
{
    public interface IFindCustomerByIdHandler
    {
        FindCustomerByIdResponse Handle(FindCustomerByIdRequest command);
    }
}