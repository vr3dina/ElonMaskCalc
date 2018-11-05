using EM.Calc.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Core.Calc calc { get; set; }

        public CalcController()
        {
            calc = new Core.Calc(@"C:\Users\vr3dina\OneDrive\PRG\ituniver\UserDLLS");
        }

        public ActionResult Execute(string oper, double[] args)
        {
            var model = Calc(oper, args);

            return View(model);
        }

        [HttpGet]
        public ActionResult Input()
        {
            InputModel model = new InputModel()
            {
                Operations = calc.Operations
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Input(InputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (!calc.Operations.Any(op => op.Name == model.OperationName))
            {
                ModelState.AddModelError("OperationName", "Такой операции нет");
                return View(model);
            }

            var res = Calc(model.OperationName, model.Args);
            return View("Execute", res);
        }

        private OperationResult Calc(string oper, double[] args)
        {
            var res = calc.Calculate(oper, args);

            return new OperationResult()
            {
                Name = oper,
                Result = res
            };

        }

    }
}
