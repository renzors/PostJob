using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenSite.Models;

namespace ListenSite.Controllers
{
    public class HomeController : Controller
    {
        private static List<Site> _sites = new List<Site>();
        public ActionResult Index()
        {
            return View(_sites);
        }

        [HttpPost]
        public ActionResult Index(string siteName)
        {
            if (_sites.Any(x => x.Name == siteName))
                _sites.Remove(_sites.FirstOrDefault(x => x.Name == siteName));

            _sites.Add(new Site(){ LastDateTime = DateTime.Now, Name = siteName });

            return View(_sites);
        }
    }
}