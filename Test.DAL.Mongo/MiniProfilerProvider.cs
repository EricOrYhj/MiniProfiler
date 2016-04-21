using StackExchange.Profiling.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DAL.Mongo
{
    public class MiniProfilerProvider
    {
        private static string conUrl = "mongodb:/172.17.30.103:27017";

        public MiniProfilerProvider()
        {
            StackExchange.Profiling.MiniProfiler.Settings.Storage = new MongoDbStorage(conUrl);
        }
    }
}
