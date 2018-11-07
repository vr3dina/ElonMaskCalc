﻿using System;

namespace EM.Calc.DB
{
    public class OperationResult : IEntity
    {
        public long Id { get; set; }

        public long OperationId { get; set; }

        public double? Result { get; set; }

        public string Args { get; set; }

        public DateTime? CreationDate { get; set; }

        public int Status { get; set; }

        public long UserId { get; set; }

        public long ExecTime { get; set; }
    }
}