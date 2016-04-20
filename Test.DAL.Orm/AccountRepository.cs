using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity.Orm;

using StackExchange.Profiling;
using StackExchange.Profiling.Storage;

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

            //MiniProfiler.Settings.Storage = new SqlServerStorage(DbConnection);

            //var profiler = MiniProfiler.Current;
            //using (profiler.Step("data get account"))
            //{
                return this.Single(a => (a.Email == account || a.MobilePhone == account) && a.Status == status);
            //}
        }
    }
}
