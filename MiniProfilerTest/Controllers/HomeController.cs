using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using StackExchange.Profiling;

namespace MiniProfilerTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var profiler = StackExchange.Profiling.MiniProfiler.Current;
            using (profiler.Step("获取Product列表"))
            {
                var aaa = Test.DAL.Orm.AccountRepository.Instance.GetAccount("b@md.md", 1);

                return View(aaa);
            }
        }

        [HttpGet]
        public JsonResult Get()
        {
            var profiler = StackExchange.Profiling.MiniProfiler.Current;
            using (profiler.Step("获取Product列表"))
            {
                var aaa = Test.DAL.Orm.AccountRepository.Instance.GetAccount("b@md.md", 1);

                return Json(new
                {
                    PageNumber = aaa.AccountId,
                    PageSize = aaa.AccountId
                },JsonRequestBehavior.AllowGet);
            }
        }

    }
}
