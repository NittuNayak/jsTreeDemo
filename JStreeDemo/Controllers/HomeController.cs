using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JStreeDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public JsonResult GetPublications()
        {
            List<TreeStructure> treestructureList = new List<TreeStructure>();
            treestructureList.Add(new TreeStructure() { id = "1", text = "Root", parent = "#" });
            treestructureList.Add(new TreeStructure() { id = "2", text = "Level1", parent = "1" });
            treestructureList.Add(new TreeStructure() { id = "3", text = "Level2", parent = "1" });
            treestructureList.Add(new TreeStructure() { id = "4", text = "Level3", parent = "1" });
            treestructureList.Add(new TreeStructure() { id = "5", text = "Level4", parent = "2" });
            treestructureList.Add(new TreeStructure() { id = "6", text = "Level5", parent = "2" });



            return Json(treestructureList, JsonRequestBehavior.AllowGet);
        }
    }

    public class TreeStructure
    {
        public string id { get; set; }
        public string text { get; set; }
        public string parent { get; set; }
    }
}