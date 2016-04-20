using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using StackExchange.Profiling;

namespace MiniProfilerTest.Controllers
{
    public class HomeApiController : ApiController
    {
        //
        // GET: /HomeApi/
        [HttpGet]
        public JObject Index()
        {
            JObject resultObj = new JObject();

            var profiler = MiniProfiler.Current;
            using (profiler.Step("action get account"))
            {
                var aaa = Test.DAL.Orm.AccountRepository.Instance.GetAccount("b@md.md", 1);

                resultObj.Add("accountid", "fefsef");

                return resultObj;
            }
        }

    }
}
