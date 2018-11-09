using EM.Calc.DB;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class HomeController : Controller
    {
        IEntityRepository<User> userRepository;

        public HomeController()
        {
            userRepository = new NHUserRepository();
        }

        public ActionResult Index()
        {

            ViewBag.Results = userRepository.Load(2);

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