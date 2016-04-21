using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Configuration;

using MongoDB.Driver;

using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver.Builders;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization;
using System.Threading;
using StackExchange.Profiling.MongoDB;
using Test.Entity.Mongo;


namespace Test.DAL.Mongo
{
    public abstract class MongoBaseProvider<T> where T : class
    {
        public string databaseName = "NoDatabaseName";
        public string collectionName = "NoName";

        public MongoClient Client = null;
        public MongoServer Server = null;
        public MongoBaseProvider(string conUrl)
        {
            var setting = MongoClientSettings.FromUrl(new MongoUrl(conUrl));
            Client = new MongoClient(setting);
            Server = new ProfiledMongoServer(Client.GetServer());
        }

        private MongoCollection<T> GetCollection()
        {
            var database = Server.GetDatabase(databaseName);
            return database.GetCollection<T>(collectionName);
        }

        #region  查询

        public T FindOne()
        {
            var query = Query.And(Query.EQ("gid", "30e5a110-340e-11e5-954a-03aa8058d175"));

            var x = GetCollection().FindOne(query);

            return x;
        }

        #endregion

    }
}
