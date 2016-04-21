using StackExchange.Profiling.MongoDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entity.Mongo;

namespace Test.DAL.Mongo
{
    public class GroupProvider : MongoBaseProvider<Group>
    {
        private static string conUrl = "mongodb://172.17.30.240:27017,172.17.30.103:27017/?readPreference=SecondaryPreferred";

        public GroupProvider()
            : base(conUrl)
        {
            collectionName = "groups";
            databaseName = "mdgroups";
        }

        public static GroupProvider Instance
        {
            get { return new GroupProvider(); }
        }

        public Group GetGroupDetail()
        {
            return this.FindOne();
        }
    }
}
