using System;

namespace EM.Calc.DB
{
    public class OperationResult : IEntity
    {
        public virtual long Id { get; set; }
              
        public virtual long OperationId { get; set; }

        public virtual Operation Operation { get; set; }
              
        public virtual double? Result { get; set; }
              
        public virtual string Args { get; set; }
              
        public virtual DateTime? CreationDate { get; set; }
              
        public virtual long UserId { get; set; }
              
        public virtual User User { get; set; }
              
        public virtual long ExecTime { get; set; }
              
        public virtual OperationResultStatus Status { get; set; }
              
        public enum OperationResultStatus
        {
            DONE,
            EXECUTING,
            FAIL
        }
    }
}
