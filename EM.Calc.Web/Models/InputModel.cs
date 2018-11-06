using EM.Calc.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EM.Calc.Web.Models
{
    public class InputModel
    {
        public InputModel()
        {
            Operations = new List<IOperation>();
        }

        [Display(Name = "Операция")]
        [Required(ErrorMessage = "Нам обязательно нужно знать операцию")]
        public string OperationName { get; set; }

        [Display(Name = "Параметры")]
        [Required]
        public double[] Args { get; set; }

        public IList<IOperation> Operations { get; set; }
    }
}