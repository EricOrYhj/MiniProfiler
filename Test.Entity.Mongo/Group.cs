using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson.Serialization.Attributes;

namespace Test.Entity.Mongo
{
    public class Group
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        public ObjectId _id { get; set; }

        [BsonIgnore]
        public int AutoId { get; set; }

        private string groupId = string.Empty;
        [BsonElement("gid")]
        public string GroupId
        {
            get { return groupId; }
            set { groupId = value; }
        }

        private string name = string.Empty;
        [BsonElement("name")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string about = string.Empty;
        [BsonElement("about")]
        public string About
        {
            get { return about; }
            set { about = value; }
        }

        private string avatar = string.Empty;
        [BsonElement("avatar")]
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        private int numFollower = 1;
        [BsonElement("nFollower")]
        public int NumFollower
        {
            get { return numFollower; }
            set { numFollower = value; }
        }

        private int numPost = 0;
        [BsonElement("nPost")]
        public int NumPost
        {
            get { return numPost; }
            set { numPost = value; }
        }

        private bool isEmail = false;
        [BsonElement("isEmail")]
        public bool IsEmail
        {
            get { return isEmail; }
            set { isEmail = value; }
        }

        private bool isVerified = false;
        [BsonElement("isVerified")]
        public bool IsVerified
        {
            get { return isVerified; }
            set { isVerified = value; }
        }

        private bool isPost = true;
        [BsonElement("isPost")]
        public bool IsPost
        {
            get { return isPost; }
            set { isPost = value; }
        }
        private bool isApproval = true;
        [BsonElement("isApproval")]
        public bool IsApproval
        {
            get { return isApproval; }
            set { isApproval = value; }
        }

        private bool isHidden = true;
        [BsonElement("isHidden")]
        public bool IsHidden
        {
            get { return isHidden; }
            set { isHidden = value; }
        }

        private int status = 1;
        [BsonElement("status")]
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private string projectId = string.Empty;
        [BsonElement("pid")]
        public string ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
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

        private DateTime lastTime = DateTime.Now;
        [BsonElement("ltime")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime LastTime
        {
            get { return lastTime; }
            set { lastTime = value; }
        }

        private List<GroupUsers> users = new List<GroupUsers>();
        [BsonElement("users")]
        public List<GroupUsers> Users
        {
            get { return users; }
            set { users = value; }
        }

        private List<GroupAdmins> admins = new List<GroupAdmins>();
        [BsonElement("admins")]
        public List<GroupAdmins> Admins
        {
            get { return admins; }
            set { admins = value; }
        }

        private bool isEditedName = false;
        [BsonElement("ename")]
        public bool IsEditedName
        {
            get { return isEditedName; }
            set { isEditedName = value; }
        }

        private int fromType = 1;
        [BsonElement("ftype")]
        public int FromType
        {
            get { return fromType; }
            set { fromType = value; }
        }

        private string dbserver = string.Empty;
        [BsonElement("dbserver")]
        public string DbServer
        {
            get { return dbserver; }
            set { dbserver = value; }
        }

    }
}
