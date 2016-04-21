using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entity.Mongo
{
    [BsonIgnoreExtraElements]
    public class GroupUsers
    {

        private string userAccountId = string.Empty;
        [BsonElement("aid")]
        public string UserAccountId
        {
            get { return userAccountId; }
            set { userAccountId = value; }
        }

        private int status = 1;
        [BsonElement("status")]
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private bool sendEmail = false;
        [BsonElement("isEmail")]
        public bool SendEmail
        {
            get { return sendEmail; }
            set { sendEmail = value; }
        }

        private bool isPush = true;
        [BsonElement("isPush")]
        public bool IsPush
        {
            get { return isPush; }
            set { isPush = value; }
        }


        private string createUserAccountId = string.Empty;
        [BsonElement("caid")]
        public string CreateUserAccountId
        {
            get { return createUserAccountId; }
            set { createUserAccountId = value; }
        }


        private string modifyUserAccountId = string.Empty;
        [BsonElement("uaid")]
        public string ModifyUserAccountId
        {
            get { return modifyUserAccountId; }
            set { modifyUserAccountId = value; }
        }

        private DateTime createTime = DateTime.Now;
        [BsonElement("ctime")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        private DateTime updateTime = DateTime.Now;
        [BsonElement("utime")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
    }
}
