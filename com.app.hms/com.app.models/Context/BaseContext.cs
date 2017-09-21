using System;
using System.Data.Entity;

namespace com.app.models.Context
{
    public class BaseContext<TContext>
         : DbContext where TContext : DbContext
    {
        private volatile Type _dependency;
        static BaseContext()
        {

            Database.SetInitializer(new CreateDatabaseIfNotExists<TContext>());
        }

        protected BaseContext()
            : base("name=TestDb")
        {
            Configuration.LazyLoadingEnabled = false;
            _dependency = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        protected BaseContext(string connectionName)
            : base(connectionName)
        {
            _dependency = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }
    }
}
