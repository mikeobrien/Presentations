using DDDApplication.Domain;

namespace DDDApplication.Infrastructure
{
    public class CustomerRepository : RepositoryBase<Customer>, IRepository<Customer>
    {
        public CustomerRepository(IDatabase database) : base(database) { }
    }
}
