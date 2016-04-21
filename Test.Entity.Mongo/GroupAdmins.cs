using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class GroupAdmins
    {

        private string userAccountId = string.Empty;
        [BsonElement("aid")]
        public string UserAccountId
        {
            get { return userAccountId; }
            set { userAccountId = value; }
        }

        private string createUserAccountId = string.Empty;
        [BsonElement("caid")]
        public string CreateUserAccountId
        {
            get { return createUserAccountId; }
            set { createUserAccountId = value; }
        }

        private DateTime createTime = DateTime.Now;
        [BsonElement("ctime")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

    }
}
