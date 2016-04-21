using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using StackExchange.Profiling;
using MiniProfilerTest.App_Start.Action;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

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

        [HttpGet]
        public IHttpActionResult Get()
        {
            return new TextResult("hello", Request);
        }

        [HttpGet]
        public HttpResponseMessage GetMessage()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, "value");

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html; charset=utf-8");

            response.Content = new StringContent("", Encoding.Unicode);
    
            return response;
        } 
    }
}
