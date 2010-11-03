using DDDApplication.Domain;
using DDDApplication.Infrastructure;
using StructureMap;

namespace DDDApplication.Application
{
    public class Registry
    {
        private static Registry _registry;

        private Registry()
        {
            ObjectFactory.Initialize(x =>
            {
                // Database 
                x.For<IDatabase>().Use<SqlDatabase>();
                
                // Repositories
                x.Scan(config =>
                           {
                               config.TheCallingAssembly();
                               config.ConnectImplementationsToTypesClosing(typeof (IRepository<>));
                           });
            });
        }

        public static Registry Current
        {
            get
            {
                if (_registry == null) _registry = new Registry();
                return _registry;
            }
        }

        public T Resolve<T>()
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}
