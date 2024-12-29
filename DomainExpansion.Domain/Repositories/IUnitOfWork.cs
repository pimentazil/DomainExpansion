namespace DomainExpansion.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
