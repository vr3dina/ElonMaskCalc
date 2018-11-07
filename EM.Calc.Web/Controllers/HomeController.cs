using EM.Calc.DB;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class HomeController : Controller
    {
        UserRepository userRepository;
        OperationRepository operationRepository;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vr3dina\OneDrive\PRG\ituniver\ElonMaskCalc\EM.Calc.Web\App_Data\ElonMusk.mdf;Integrated Security=True";

        public HomeController()
        {
            userRepository = new UserRepository(connectionString);
            operationRepository = new OperationRepository(connectionString);
        }

        public ActionResult Index()
        {
            
            ViewBag.Results = userRepository.GetAll(); 
            ViewBag.Op = operationRepository.Load(2);

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