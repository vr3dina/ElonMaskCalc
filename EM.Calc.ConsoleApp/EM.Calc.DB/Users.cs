using System;

namespace EM.Calc.DB
{
    public class Users : IEntity
    {
        public long Id { get; set; }

        public string Login { get; set; }

        public DateTime? BirthDay { get; set; }

        public bool Sex { get; set; }

    }
}
