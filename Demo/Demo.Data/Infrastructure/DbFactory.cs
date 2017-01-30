using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DemoEntities dbContext;

        public DemoEntities Init()
        {
            return dbContext ?? (dbContext = new DemoEntities());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
