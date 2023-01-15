using System;
using System.Web.Mvc;
using DotNetRedisSessionSample.Models;

namespace DotNetRedisSessionSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // NOTE セッションデータの保存
            this.HttpContext.Session[SampleSessionData.SampleSessionDataKey] = new SampleSessionData
            {
                LastAccessTime = DateTime.Now
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            // NOTE セッションデータの取得
            var data = this.HttpContext.Session[SampleSessionData.SampleSessionDataKey] as SampleSessionData;

            ViewBag.Message = $"Your contact page.LastAccessTime: {data?.LastAccessTime}";

            return View();
        }
    }
}