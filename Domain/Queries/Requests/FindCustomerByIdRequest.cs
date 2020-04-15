using System;
using MediatR;
using ShopCqrsMediator.Domain.Queries.Responses;

namespace ShopCqrsMediator.Domain.Queries.Requests
{
    public class FindCustomerByIdRequest : IRequest<FindCustomerByIdResponse>
    {
        public Guid Id { get; set; }
    }
}