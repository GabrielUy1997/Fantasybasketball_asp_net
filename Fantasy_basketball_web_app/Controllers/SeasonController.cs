using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fantasy_basketball_web_app.Models;

namespace Fantasy_basketball_web_app.Controllers
{
    public class SeasonController : Controller
    {

        public ActionResult SeasonSelect()
        {
            nbaStatsEntities reterive = new nbaStatsEntities();
            string yesy = TempData["season"].ToString();
            var season = new Season() { SeasonSelected = yesy};
            season.LoadSeason(reterive);
            ViewData["pts"] = season.PlayerList;
            return View();
        }

        

        // GET: Season
        
    }
}