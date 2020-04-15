using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using ShopCqrsMediator.Domain.Commands;
using ShopCqrsMediator.Domain.Commands.Responses;
using ShopCqrsMediator.Domain.Entities;
using ShopCqrsMediator.Domain.Repositories;

namespace ShopCqrsMediator.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        ICustomerRepository _repository;
        IEmailRepository _emailRepository;

        public CreateCustomerHandler(ICustomerRepository repository, IEmailRepository emailRepository)
        {
            _repository = repository;
            _emailRepository = emailRepository;
        }

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Aplicar fail fast validations

            //Criar entidade
            var customer = new Customer(request.Name, request.Email);

            // Persiste a entidade
            _repository.Save(customer);

            //Envia email de boas-vindas
            _emailRepository.Send(customer.Name, customer.Email);

            // Retorna a resposta
            var result = new CreateCustomerResponse
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Date = DateTime.Now
            };
            return Task.FromResult(result);
        }
    }
}