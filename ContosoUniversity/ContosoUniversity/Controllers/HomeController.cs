using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.common;
namespace ContosoUniversity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = WeatherHelper.GetWeatherByCityName("玉林");
            return View(data);
        }
        //public JsonResult getweather(string city)
        //{
        //    var data = WeatherHelper.GetWeatherByCityName();
        //}
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}