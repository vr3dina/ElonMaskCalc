using EM.Calc.DB;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class OperationResultController : Controller
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\vr3dina\OneDrive\PRG\ituniver\ElonMaskCalc\EM.Calc.Web\App_Data\ElonMusk.mdf;Integrated Security=True";
        OperationResultRepository OperationResultRepository;

        public OperationResultController()
        {
            OperationResultRepository = new OperationResultRepository(connectionString);
        }

        // GET: OperationResult
        public ActionResult Index()
        {
            ViewBag.OpRes = OperationResultRepository.GetAll();

            return View(ViewBag.OpRes);
        }
    }
}