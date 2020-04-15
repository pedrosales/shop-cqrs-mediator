namespace ShopCqrsMediator.Domain.Repositories
{
    public interface IEmailRepository
    {
        void Send(string name, string email);
    }
}