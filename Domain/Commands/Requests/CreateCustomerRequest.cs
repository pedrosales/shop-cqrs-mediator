using MediatR;
using ShopCqrsMediator.Domain.Commands.Responses;

namespace ShopCqrsMediator.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}