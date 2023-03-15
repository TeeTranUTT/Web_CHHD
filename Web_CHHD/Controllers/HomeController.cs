using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHHDBase;

namespace Web_CHHD.Controllers
{
    public class HomeController : Controller
    {
        private CHHDDbContext db = new CHHDDbContext();
        public ActionResult Index()
        {
            using (var db = new CHHDDbContext() )
            {
                var customerHome = (from item in db.ImagePages
                                    where item.Status == true && item.Page == "Home" && item.Location == "CustomerHome"
                                    select new ImagePageModel
                                    {
                                        PageName = item.PageName,
                                        Image = item.Image,
                                        Description = item.Description,
                                        Title = item.Title
                                    }).ToList();
                var sliderHome = (from item in db.ImagePages
                                    where item.Status == true && item.Page == "Home" && item.Location == "Slider"
                                    select new ImagePageModel
                                    {
                                        PageName = item.PageName,
                                        Image = item.Image,
                                        Description = item.Description,
                                        Title = item.Title
                                    }).ToList();
                @ViewBag.CustomerHome = customerHome;
                @ViewBag.SliderHome = sliderHome;
            }
           
            
            return View();
        }

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