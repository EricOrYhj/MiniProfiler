using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using StackExchange.Profiling;
using MiniProfilerTest.App_Start;

namespace MiniProfilerTest.Controllers
{
    public class HomeController : Controller
    {
        const string PUBLICKEY =
@"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCtEu4kIhyGEsrihFNEOU5TxXLX
s3M9if7mIRt19579VYUD+FkBtE3nKCnEDfIpsnm/L57NeGA5WIgq8HWukI31ZvjO
3VQSRbmOe+eqt4eKvjnrtLqETbGkWgNTDSy0pkwb5Ns6fCqS+8V60ogshYpWg0yO
cZU+dfjiqR6ePcY8VwIDAQAB
-----END PUBLIC KEY-----";


        const string PRIVATEKEY =
@"-----BEGIN RSA PRIVATE KEY-----
MIICXQIBAAKBgQCtEu4kIhyGEsrihFNEOU5TxXLXs3M9if7mIRt19579VYUD+FkBtE3nKCnEDfIpsnm/L57NeGA5WIgq8HWukI31ZvjO3VQSRbmOe+eqt4eKvjnrtLqETbGkWgNTDSy0pkwb5Ns6fCqS+8V60ogshYpWg0yOcZU+dfjiqR6ePcY8VwIDAQABAoGAHNPeXp5f6eUPbhNkWyTAayukKVF2jHWDw4kYLdoE3WV1NmgTSzlhEHOcIU/BWjikFrgz1z2JqYOZiq1qrJzfSA6VBwhXE0n6SbF+uWq73j3GCzaqXM/Q6MOxMmssBAnfw4ekNDLtDt/lVn3KgDFVjJufb94EV/yI5XcHfSdzsAECQQDfKWnA1LnjGsrkyIRl4OxrBCO74fPj6Zal02IU5d6IHjM707Ch0ZNtxLVV0SWW5pKpR7fc9/LNIF2PNa8p9P5XAkEAxoqwsBnCvOtpilqmJN/pbRgdafDHVUqGm3hPnNnx1yv/8DxDDIFLDBMyCudKkjLejyjfRT+hAOj7rOIs69XyAQJBAMznSpnq+S9kt20wDBk7V/i/GUx3IKhhH5jtKX7Evfo/uI0zR1idhP/iARpl6lzPI1TZbCIxbDgagq1u/oHI2QsCQBmhFaXl7WmNyhX+Fax06yEWF9XxKworkKzJHx3UVI++Mk/Et7MJjbKFV9RofwvYXTqFwCykRhhj+vkaSUo4WAECQQDUVbE9Gg5TQ1nL3Erx+hpvZ1Rh2ac8nbP5HC7NIL+9mdZN4KP4VPo3EM/B74WglC0gSTN3YDxp8Zu/iARtEIeU
-----END RSA PRIVATE KEY-----";

//        const string PUBLICKEY =
//@"-----BEGIN PUBLIC KEY-----
//MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCtEu4kIhyGEsrihFNEOU5TxXLX
//s3M9if7mIRt19579VYUD+FkBtE3nKCnEDfIpsnm/L57NeGA5WIgq8HWukI31ZvjO
//3VQSRbmOe+eqt4eKvjnrtLqETbGkWgNTDSy0pkwb5Ns6fCqS+8V60ogshYpWg0yO
//cZU+dfjiqR6ePcY8VwIDAQAB
//-----END PUBLIC KEY-----";


//        const string PRIVATEKEY =
//@"-----BEGIN RSA PRIVATE KEY-----
//MIICXQIBAAKBgQDXQqacLKxDxKJzfNVCr39khKPlgNwdatGilshrY+phoflUX8S8
//dPCZFAGbxMODjoWqI2sGNIfKwsPmZdBGr/243dFefhXgpEoDL0wOFZrJXZfb6wg9
//ltHt87tI0FLd75cb4hceC8TRAKaRS6FHnwzJUracC14MTwTKxTU4x3NyxwIDAQAB
//AoGAJ1bV7gq3/LaN3b89li9Of8dB0KqJD5M69pTJ0d5zsh4Q29uYr7xLUB544MfH
//114PjXVllL+65VJMzOlkc9ar7mv3GVIyU7NbwExCLUfWvIWIncLy6nJfvFrHvdYe
//7iwMKCH6DoKhDMdeZuCX7XQw//7S9SjoG1uQyjkFlRhZEkECQQD/fnxppWe/U2wG
//4Ali8ngV9+HXzfHSyCOxtchLJTo0MXFvU2mAQntfFWxjmXdGdbRHyvX/Zqs91VJ0
//9K7i2q8nAkEA16/FDBbqhuKiW5puiwd32si1wDIJelXz11yW0QpokYSRtyMGM5Wr
//ZbGVyL4iuFZbWLPcrq7krPrD9g6FMS1jYQJBAIaxMfmoH5e37P164rftR+2c7s0M
//X25V4KtxQBSNna+iWUDtYnMhmVS5QJkJcN4Oc2pdz25DvAcvDPdnf0NNMoUCQQCC
//6lJdMy+pLbjEhykfxCmwp3ECNpzgH3nBN5bnTT0JToEvuteRyf/d2vuCfD4Qy4Ho
//hkulz8xHXnJBULDxl44hAkApsi+wY//9+awSPtYp8mb9s0Z+eMjU6UCxjXpq3mK9
//Ae6x0G/c9tE1SPgEBByGeEeo6CT66YuzCdt8Ppjah9zZ
//-----END RSA PRIVATE KEY-----";

        //
        // GET: /Home/

        public ActionResult Index()
        {
            //var profiler = StackExchange.Profiling.MiniProfiler.Current;

            //var aaa = Test.DAL.Orm.AccountRepository.Instance.GetAccount("b@md.md", 1);

            var bbb = Test.DAL.Mongo.GroupProvider.Instance.GetGroupDetail();

            //string ccc = Rsa.RSAEncrypt(PUBLICKEY, "12345");
            //var aa = Rsa.RSADecrypt(PRIVATEKEY, ccc);

            var aa = Rsa.RSADecrypt(PRIVATEKEY, "HpnTKD8UkvdrdevUO/6eFDKig+YVed4Diwy1CCROr2CgTl+tIEjNGBwHLMZwfZ+4zo4uiq3nOHBCSN3pj4921FSARPchXGN/VjPfsOvfhKUnE1RfWgLSbksCxyTKKzeqaGkrlfJKh9KjyZg/AmXvlI5WdO+Bm+c33uL8HvuOMxs=");

            return View(bbb);
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
                }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
