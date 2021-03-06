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

            return PartialView("HomeSearchPartial", homeModel);

        }

        [HttpPost]
        [ValidateUmbracoFormRouteString]
        public ActionResult Submit(HomeModel model, string button)
        { 

            var contentService = Services.ConsentService;
            var postCode = Request.Form["postcode"];

            model.Postcode = postCode;



            return RedirectToCurrentUmbracoPage();
        }


    }
}