using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity.Orm;

using StackExchange.Profiling;
using StackExchange.Profiling.Storage;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;

namespace Test.DAL.Orm
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository()
        {
            DbConnection = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        }

        public static AccountRepository Instance
        {
            get { return new AccountRepository(); }
        }

        public Account GetAccount(string account, int status = 1)
        {
            var profiler = MiniProfiler.Current;

            using (profiler.Step("data get account"))
            {
                using (var db = OpenDbConnection())
                {
                    var q = db.From<Account>().Where(a => (a.Email == account || a.MobilePhone == account) && a.Status == status);

                    return db.Single<Account>(q);
                }
            }
        }
    }
}
