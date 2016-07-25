using System.Web.Mvc;

namespace DocsTemplate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult FirstPage() { return View(); }
        public ActionResult SomePage() { return View(); }
        public ActionResult TextPreprocessing() { return View(); }
    }
}