using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entity.Orm
{
    [Alias("Account")]
    public class Account
    {
        [AutoIncrement]
        public int AutoId { get; set; }
        private string accountId = Guid.NewGuid().ToString();

        public string AccountId
        {
            get { return accountId; }
            set { accountId = value == null ? value : value.ToLower(); }
        }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int? Status { get; set; }

        private DateTime? updateTime;

        public DateTime? UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        private DateTime? createTime;

        public DateTime? CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
    }
}
