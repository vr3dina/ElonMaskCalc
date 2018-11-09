using EM.Calc.DB;
using EM.Calc.DB.NHibernate;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class OperationResultController : Controller
    {
       IEntityRepository<OperationResult> OperationResultRepository;

        public OperationResultController()
        {
            OperationResultRepository = new NHOperationResultRepository();
        }

        // GET: OperationResult
        public ActionResult Index()
        {
            ViewBag.OpRes = OperationResultRepository.GetAll();

            return View(ViewBag.OpRes);
        }
    }
}