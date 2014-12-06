using System.Web.Mvc;

namespace Web.Controllers
{
    [RequireHttps]
    public class FrontpageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}