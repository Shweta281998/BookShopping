using DomainModels.Entites;
using DomainModels.Entities;
using Repository.Abstraction;

namespace Repository
{
    public interface IUnitOfWork
    {
        IAuthenticateRepository AuthenticateRepository { get;}

        IRepository<Category> CategoryRepository { get; }

        IRepository<Product> ProductRepository { get; }

        int SaveChanges();
    }
}
