using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Execute(string oper, double[] args)
        {
            args = args ?? new[] { 0.0 };

            var calc = new Core.Calc();
            var res = calc.Calculate(oper, args);

            ViewBag.Operation = oper;
            ViewBag.Operands = string.Join(" ", args);
            ViewBag.Result = res;

            return View();
        }

    }
}
