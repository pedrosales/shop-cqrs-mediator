using Microsoft.EntityFrameworkCore;
using ShopCqrsMediator.Data.Context;
using ShopCqrsMediator.Domain.Entities;
using ShopCqrsMediator.Domain.Queries.Requests;
using ShopCqrsMediator.Domain.Queries.Responses;
using ShopCqrsMediator.Domain.Repositories;

namespace ShopCqrsMediator.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context)
        {
            _context = context;
        }
        public FindCustomerByIdResponse GetCustomerById(FindCustomerByIdRequest command)
        {
            var customer = _context.Customers.AsNoTracking().FirstOrDefaultAsync(x => x.Id == command.Id).Result;

            return new FindCustomerByIdResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email
            };
        }

        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }
    }
}