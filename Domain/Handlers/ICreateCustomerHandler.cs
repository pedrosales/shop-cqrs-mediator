using ShopCqrsMediator.Domain.Commands;
using ShopCqrsMediator.Domain.Commands.Responses;

namespace ShopCqrsMediator.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}