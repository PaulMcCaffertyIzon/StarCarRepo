using StarCarHire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.Models;

namespace StarCarHire.Controllers
{
    public class HomeController : SurfaceController
    {
        // GET: Results

        public ActionResult Render()
        {
            var homeModel = new HomeModel();
            var postCode = Request.Form["postcode"];

            return PartialView("HomeSearchPartial", homeModel);

        }

        [HttpPost]
        [ValidateUmbracoFormRouteString]
        public ActionResult Submit(HomeModel model)
        {
            var contentService = Services.ConsentService;
            var parentId = new Guid("");            

            return RedirectToCurrentUmbracoPage();
        }


    }
}