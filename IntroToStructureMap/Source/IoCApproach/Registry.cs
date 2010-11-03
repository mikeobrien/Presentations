using System;
using IoCApproach.Email;
using IoCApproach.Logging;
using StructureMap;

namespace IoCApproach
{
    public class Registry
    {
        private static Registry _registry;

        private Registry()
        {
            ObjectFactory.Initialize(x =>
            {
                // Log Service
                //x.ForSingletonOf<ILogService>().Use<FileLogService>();
                
                x.ForSingletonOf<ILogService>().Add((context => new FileLogService(System.Configuration.ConfigurationManager.AppSettings["LogPath"])));

                // Email Service
                //x.ForSingletonOf<IEmailService>().Use<NetEmailService>();

                x.ForSingletonOf<IEmailService>().
                    Use<NetEmailService>().
                    Ctor<string>("smtpServer").
                    Is(System.Configuration.ConfigurationManager.AppSettings["SMTPServer"]);

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
