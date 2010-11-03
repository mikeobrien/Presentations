using DDDApplication.Domain;

namespace DDDApplication.Infrastructure
{
    public class BankRepository : RepositoryBase<Bank>, IRepository<Bank>
    {
        public BankRepository(IDatabase database) : base(database) { }
    }
}
