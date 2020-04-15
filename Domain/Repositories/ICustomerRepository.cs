using ShopCqrsMediator.Domain.Entities;
using ShopCqrsMediator.Domain.Queries.Requests;
using ShopCqrsMediator.Domain.Queries.Responses;

namespace ShopCqrsMediator.Domain.Repositories
{
    public interface ICustomerRepository
    {
        FindCustomerByIdResponse GetCustomerById(FindCustomerByIdRequest command);
        void Save(Customer customer);
    }
}