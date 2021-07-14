using StarCarHire.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace StarCarHire.Controllers
{
    public class ResultsController : SurfaceController
    {
        // GET: Results
        public ActionResult Render()
        {
            var resultsModel = new ResultsModel();

            return PartialView("HomeSearchPartial", resultsModel);

        }
    }
}