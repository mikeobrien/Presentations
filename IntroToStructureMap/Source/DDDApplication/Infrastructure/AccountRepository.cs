using DDDApplication.Domain;

namespace DDDApplication.Infrastructure
{
    public class AccountRepository : RepositoryBase<Account>, IRepository<Account>
    {
        public AccountRepository(IDatabase database) : base(database) { }
    }
}
