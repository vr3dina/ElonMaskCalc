using EM.Calc.DB;
using EM.Calc.DB.NHibernate;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EM.Calc.Web.Controllers
{
    public class CalcController : Controller
    {
        private Core.Calc calc { get; set; }

        IEntityRepository<OperationResult> resultRepository;
        IOperationRepository operationRepository;

        public CalcController()
        {
            calc = new Core.Calc(@"C:\Users\vr3dina\OneDrive\PRG\ituniver\UserDLLS");
            operationRepository = new NHOperationRepository();
            resultRepository = new NHOperationResultRepository();
        }

        public ActionResult Execute(string oper, double[] args)
        {
            var model = Calc(oper, args);

            return View(model);
        }

        [HttpGet]
        public ActionResult Input()
        {
            Models.InputModel model = new Models.InputModel()
            {
                Operations = calc.Operations
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Input(Models.InputModel model)
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

        [HttpPost]
        public PartialViewResult AsyncInput(Models.InputModel model)
        {
            if (!ModelState.IsValid)
            {
                return null;
            }

            if (!calc.Operations.Any(op => op.Name == model.OperationName))
            {
                ModelState.AddModelError("OperationName", "Такой операции нет");
                return null;
            }

            var res = Calc(model.OperationName, model.Args);
            return PartialView("Execute", res);
        }

        private Models.OperationResult Calc(string oper, double[] args)
        {
            var res = calc.Calculate(oper, args);

            var operation = operationRepository.LoadByName(oper);
            resultRepository.Save(new OperationResult()
            {
                UserId = 2,
                ExecTime = new Random().Next(1, 100),

                OperationId = operation.Id,
                Result = res,
                Args = string.Join(" ", args),
                CreationDate = DateTime.Now,
                Status = OperationResult.OperationResultStatus.DONE
            });

            return new Models.OperationResult()
            {
                Name = oper,
                Result = res
            };

        }

    }
}
